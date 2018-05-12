using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace UI
{
    public partial class LoginFrom : Form
    {
        public LoginFrom()
        {
            InitializeComponent();
        }

        private void LoginFrom_Load(object sender, EventArgs e)
        {
            //读取XML文件
            //创建XML文件流
            XmlDocument doc = new XmlDocument();
            //加载xml
            doc.Load(@"setup.xml");
            //获得根节点
            XmlElement root = doc.DocumentElement;
            //获得子节点
            XmlNodeList xnl = root.ChildNodes;
            //标题
            this.Text = xnl[0].InnerText+"--用户登录";
            //名称
            title.Text = xnl[0].InnerText;
            //设置图片
            pictureBox1.Image = Resource1.left;
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
