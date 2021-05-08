using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
using System.Xml;
using UnityEngine.Networking;
using UnityEngine.UI;
//xml操作
public class Tools 
{
    //读取关卡列表方法
    public static List<FileInfo> RideFird()
    {
        List<FileInfo> fileInfos = new List<FileInfo>();
        string[] S_fird = Directory.GetFiles("路径","*.xlm");
        for (int i=0; i<=S_fird.Length;i++)
        {
            FileInfo file = new FileInfo(S_fird[i]);
            Debug.Log(S_fird[i]);
            fileInfos.Add(file);
        }
        return fileInfos;
    }
    //读取文件,解释脚本
    public static void FillLevel(string FileName,Level level)
    {
        StreamReader sb;
        //寻找文件
        FileInfo files = new FileInfo(FileName);
        sb = new StreamReader(files.OpenRead(),Encoding.UTF8);
        XmlDocument doc = new XmlDocument();
        //从指定流加载Xml文档
        doc.Load(sb);
        level.Name = doc.SelectSingleNode("/Level/Name/").InnerText;//根据官方文档返回值等于string;
        level.CardImage = doc.SelectSingleNode("/Level/CardImage/").InnerText;
        level.BackGround = doc.SelectSingleNode("/Level/BadkGround/").InnerText;
        level.Rond = doc.SelectSingleNode("/Level/Road/").InnerText;
        level.InitScore = int.Parse(doc.SelectSingleNode("/Level/InitScore/").InnerText);

        XmlNodeList nodes;//获取成组信息
        nodes = doc.SelectNodes("/Level/Holder/Point/");
        for (int i=0;i<=nodes.Count;i++ )
        {
            XmlNode node = nodes[i];
            Point point = new Point(int.Parse( node.Attributes["X"].Value),int.Parse(node.Attributes["Y"].Value));
            level.Points.Add(point);
        }
        nodes = doc.SelectNodes("/Level/Path/Point/");
        for (int i=0; i<=nodes.Count;i++)
        {
            XmlNode node = nodes[i];
            Point path = new Point(int.Parse(node.Attributes["X"].Value),int.Parse(node.Attributes["Y"].Value));
            level.Path.Add(path);
        }
        //读取怪物模型和数量
        nodes = doc.SelectNodes("/Level/Rounds/Round");
        for (int i=0;i<=nodes.Count;i++)
        {
            XmlNode node = nodes[i];
            Round round = new Round(int.Parse(node.Attributes["Monster"].Value),int.Parse(node.Attributes["Count"].Value));
            level.Round.Add(round);
        }
        sb.Close();
        sb.Dispose();
    }
    public static void SaveLeve(string FileName,Level level)
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");//写入后自动换行
        sb.AppendLine("<Level>");
        sb.AppendLine(string.Format("<Name>{0}</Name>",level.name));
        sb.AppendLine(string.Format("<CardImage>{0}</CardImage>",level.CardImage));
        sb.AppendLine(string.Format("<Background>{0}</Background>",level.BackGround));
        sb.AppendLine(string.Format("<InitScore>{0}<InitScore>",level.InitScore));
        sb.AppendLine("<Holder>");
        for (int i=0;i<=level.Points.Count;i++)
        {
            sb.AppendLine(string.Format("<Point X=\"{0}\"Y=\"{1}\"/>",level.Points[i].x,level.Points[i].y));
        }
        sb.AppendLine("</Holder>");
        sb.AppendLine("<Path>");
        for (int i=0;i<=level.Round.Count;i++)
        {
            sb.AppendLine(string.Format("<Point X=\"{0}\"Y=\"{1}\"/>",level.Path[i].x,level.Path[i].y));
        }
        sb.AppendLine("</Path>");
        sb.AppendLine("<Rounds>");
        for (int i=0;i<=level.Round.Count;i++)
        {
            sb.AppendLine(string.Format("<Rounds>Monster=\"{0}\"Count=\"{1}\"</Rounds>",level.Round[i].Monster,level.Round[i].Count));
        }
        //sb.AppendLine("<Rounds>Monster{0}{1}</Rounds>");
        sb.AppendLine("</Rounds>");
        sb.AppendLine("<Level>");

        string str = sb.ToString();
        //新建一个写入流
        StreamWriter writer = new StreamWriter(FileName,false,Encoding.UTF8);
        writer.Write(writer);
        writer.Flush(); //清空缓存区
        writer.Close();//关闭读写流
        writer.Dispose();//销毁读写流
    } 
    //加载图片，模式
    public static IEnumerator AddTexture(string path,SpriteRenderer sprite)
    {
        UnityWebRequest unityWeb = new UnityWebRequest(path);
        //路径下务必保证是一个图片
        //如果判读为空返回0
        while(!unityWeb.isDone)
        {
            yield return unityWeb.SendWebRequest();
        }
        Texture2D texture= DownloadHandlerTexture.GetContent(unityWeb);
        //转换成Sprite类型
        Sprite sp = Sprite.Create(texture, new Rect( Vector2.zero,new Vector2(texture.width,texture.height)), new Vector2(0.5f,0.5f));//构建图片保存
        sprite.sprite = sp;
    }
    //加载Image
    public static IEnumerable AddImageTexture(string path,Image image)
    {
        UnityWebRequest unityWeb = new UnityWebRequest(path);
        if (!unityWeb.isDone)
        {
            yield return unityWeb.SendWebRequest(); 
        }
        Texture2D texture= DownloadHandlerTexture.GetContent(unityWeb);
        Sprite sp = Sprite.Create(texture, new Rect(Vector2.zero, new Vector2(texture.width, texture.height)), new Vector2(0.5f, 0.5f));//构建图片保存
        image.sprite = sp;
    }
}
