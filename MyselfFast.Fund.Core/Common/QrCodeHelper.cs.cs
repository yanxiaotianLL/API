using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using myselfFast.Fund.Core.Common;

namespace myselfFast.Fund.Core.Common
{
    /// <summary>
    /// 各种码生成
    /// </summary>
    public class QCodeGenerator
    {
        #region 二维码生成
        /// <summary>
        /// 
        /// </summary>
        /// <param name="content">二维码写入内容</param>
        /// <param name="outPutPath">输出目录</param>
        /// <param name="backGroundColor">背景颜色</param>
        /// <param name="frontColor">前景颜色</param>
        /// <param name="paddingTop">上填充</param>
        /// <param name="paddingLeft">左填充</param>
        /// <param name="loginPicture">公司商标</param>
        public static void Generate(string content, string outPutPath, System.Drawing.Brush backGroundColor, System.Drawing.Brush frontColor, int paddingTop, int paddingLeft, string loginPicture)
        {
            QrEncoder qrEncoder = new QrEncoder(Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.M);
            QrCode qrCode = qrEncoder.Encode(content);
            //保存成png文件
            string filename = outPutPath;
            GraphicsRenderer render = new GraphicsRenderer(new FixedModuleSize(5, QuietZoneModules.Two), backGroundColor, frontColor);
            Point padding = new Point(paddingTop, paddingLeft);
            DrawingSize dSize = render.SizeCalculator.GetSize(qrCode.Matrix.Width);
            Bitmap map = new Bitmap(dSize.CodeWidth + padding.X, dSize.CodeWidth + padding.Y);


            //追加Logo图片 ,注意控制Logo图片大小和二维码大小的比例
            Image img = Image.FromFile(loginPicture);
            using (Graphics g = Graphics.FromImage(map))
            {
                render.Draw(g, qrCode.Matrix);

                Point imgPoint = new Point((map.Width - img.Width) / 2, (map.Height - img.Height) / 2);
                g.DrawImage(img, imgPoint.X, imgPoint.Y, img.Width, img.Height);
                map.Save(filename, ImageFormat.Png);
            }
            
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <param name="stream"></param>
        /// <param name="backGroundColor"></param>
        /// <param name="frontColor"></param>
        /// <param name="paddingTop"></param>
        /// <param name="paddingLeft"></param>
        /// <param name="loginPicture"></param>
        public static void Generate(string content, Stream stream, System.Drawing.Brush backGroundColor, System.Drawing.Brush frontColor, int paddingTop, int paddingLeft, string loginPicture)
        {
            QrEncoder qrEncoder = new QrEncoder(Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.M);
            QrCode qrCode = qrEncoder.Encode(content);
            //保存成png文件

            GraphicsRenderer render = new GraphicsRenderer(new FixedModuleSize(5, QuietZoneModules.Two), backGroundColor, frontColor);
            Point padding = new Point(paddingTop, paddingLeft);
            DrawingSize dSize = render.SizeCalculator.GetSize(qrCode.Matrix.Width);
            Bitmap map = new Bitmap(dSize.CodeWidth + padding.X, dSize.CodeWidth + padding.Y);


            //追加Logo图片 ,注意控制Logo图片大小和二维码大小的比例
            Image img = Image.FromFile(loginPicture);
            using (Graphics g = Graphics.FromImage(map))
            {
                render.Draw(g, qrCode.Matrix);

                Point imgPoint = new Point((map.Width - img.Width) / 2, (map.Height - img.Height) / 2);
                g.DrawImage(img, imgPoint.X, imgPoint.Y, img.Width, img.Height);
                map.Save(stream, ImageFormat.Png);
            }           
           
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <param name="outPutPath"></param>
        /// <param name="backGroundColor"></param>
        /// <param name="frontColor"></param>
        /// <param name="paddingTop"></param>
        /// <param name="paddingLeft"></param>
        public static void Generate(string content, string outPutPath, System.Drawing.Brush backGroundColor, System.Drawing.Brush frontColor, int paddingTop, int paddingLeft)
        {
            QrEncoder qrEncoder = new QrEncoder(Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.M);
            QrCode qrCode = qrEncoder.Encode(content);
            //保存成png文件
            string filename = outPutPath;
            GraphicsRenderer render = new GraphicsRenderer(new FixedModuleSize(5, QuietZoneModules.Two), backGroundColor, frontColor);
            Point padding = new Point(paddingTop, paddingLeft);
            DrawingSize dSize = render.SizeCalculator.GetSize(qrCode.Matrix.Width);
            Bitmap map = new Bitmap(dSize.CodeWidth + padding.X, dSize.CodeWidth + padding.Y);
            using (FileStream stream = new FileStream(filename, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                render.WriteToStream(qrCode.Matrix, ImageFormat.Png, stream);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <param name="stream"></param>
        /// <param name="backGroundColor"></param>
        /// <param name="frontColor"></param>
        /// <param name="paddingTop"></param>
        /// <param name="paddingLeft"></param>
        public static void Generate(string content, Stream stream, System.Drawing.Brush backGroundColor, System.Drawing.Brush frontColor, int paddingTop, int paddingLeft)
        {
            QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.M);
            QrCode qrCode = qrEncoder.Encode(content);
            //保存成png文件

            GraphicsRenderer render = new GraphicsRenderer(new FixedModuleSize(5, QuietZoneModules.Two), backGroundColor, frontColor);
            Point padding = new Point(paddingTop, paddingLeft);
            DrawingSize dSize = render.SizeCalculator.GetSize(qrCode.Matrix.Width);
            Bitmap map = new Bitmap(dSize.CodeWidth + padding.X, dSize.CodeWidth + padding.Y);

            render.WriteToStream(qrCode.Matrix, ImageFormat.Png, stream);

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <param name="outPutPath"></param>
        /// <param name="backGroundColor"></param>
        /// <param name="frontColor"></param>
        public static void Generate(string content, string outPutPath, System.Drawing.Brush backGroundColor, System.Drawing.Brush frontColor, string loginPicture)
        {
            int paddingTop = 10;
            int paddingLeft = 10;
            Generate(content, outPutPath, backGroundColor, frontColor, paddingTop, paddingLeft, loginPicture);

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <param name="stream"></param>
        /// <param name="backGroundColor"></param>
        /// <param name="frontColor"></param>
        /// <param name="loginPicture"></param>
        public static void Generate(string content, Stream stream, System.Drawing.Brush backGroundColor, System.Drawing.Brush frontColor, string loginPicture)
        {
            int paddingTop = 10;
            int paddingLeft = 10;
            Generate(content, stream, backGroundColor, frontColor, paddingTop, paddingLeft, loginPicture);

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <param name="outPutPath"></param>
        /// <param name="backGroundColor"></param>
        /// <param name="frontColor"></param>
        public static void Generate(string content, string outPutPath, System.Drawing.Brush backGroundColor, System.Drawing.Brush frontColor)
        {
            int paddingTop = 10;
            int paddingLeft = 10;
            Generate(content, outPutPath, backGroundColor, frontColor, paddingTop, paddingLeft);

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <param name="stream"></param>
        /// <param name="backGroundColor"></param>
        /// <param name="frontColor"></param>
        public static void Generate(string content, Stream stream, System.Drawing.Brush backGroundColor, System.Drawing.Brush frontColor)
        {
            int paddingTop = 10;
            int paddingLeft = 10;
            Generate(content, stream, backGroundColor, frontColor, paddingTop, paddingLeft);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <param name="outPutPath"></param>
        public static void Generate(string content, string outPutPath)
        {
            Generate(content, outPutPath, Brushes.Black, Brushes.White);

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <param name="outPutPath"></param>
        public static void Generate(string content, Stream stream)
        {
            Generate(content, stream, Brushes.Black, Brushes.White);

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <param name="outPutPath"></param>
        /// <param name="loginPicture"></param>
        public static void Generate(string content, string outPutPath, string loginPicture)
        {
            Generate(content, outPutPath, Brushes.Black, Brushes.White, loginPicture);

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <param name="stream"></param>
        /// <param name="loginPicture"></param>
        public static void Generate(string content, Stream stream, string loginPicture)
        {
            Generate(content, stream, Brushes.Black, Brushes.White, loginPicture);

        } 
        #endregion


    }
   
}
