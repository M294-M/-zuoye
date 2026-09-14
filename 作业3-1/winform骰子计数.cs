using Cognex.VisionPro;
using Cognex.VisionPro.ImageFile;
using Cognex.VisionPro.ToolBlock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imgPath = @"D:\正课资料\三阶段\01day\04-资料\素材\骰子";
            // 获取指定文件夹下全部文件完整路径，返回字符串数组string[]
            string[] imgFiles = Directory.GetFiles(imgPath, "*.*");

            
            int sumTotal = 0;
            string VppFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Vpps", "骰子计数.vpp");
            object LOF = CogSerializer.LoadObjectFromFile(VppFilePath);
            CogToolBlock CTB = (LOF as CogToolBlock);

            foreach (string filePath in imgFiles)
            {
                CogImageFileTool imageFileTool = new CogImageFileTool();
                imageFileTool.Operator.Open(filePath, CogImageFileModeConstants.Read);
                imageFileTool.Run();

                // 将当前图片送入工具块
                CTB.Inputs["OutputImage"].Value = imageFileTool.OutputImage;
                CTB.Run();

                // 获取当前这一张图片骰子数量
                int Count = (int)CTB.Outputs["Count"].Value;

                sumTotal += Count; // 累加

               
            }

            label2.Text = $"{sumTotal}";

        }
    }
}
