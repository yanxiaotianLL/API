using BarcodeLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myselfFast.Fund.Core.Common
{
    /**********************************************************************************
     *项目名称	：myselfFast.Fund.Core.Common
     *项目描述  ：
     *类名称    ：BarCodeGenerator
     *版本号    ：v1.0.0
     *机器名称  ：LIUYONG-PC
     *项目名称  : BarCodeGenerator
     *CLR版本   : 4.0.30319.42000
     *作者      ：liu.yong
     *创建时间  : 2018-01-27 16:41:21
     *------------------------------------变更记录--------------------------------------
     *变更描述  :
     *变更作者  :
     *变更时间  :
    ***********************************************************************************/
    public static  class BarCodeGenerator
    {
        /// <summary>
        /// 生成条形码
        /// </summary>
        /// <param name="content">内容</param>
        /// <returns></returns>
        public static Image GenerateBarCodeBitmap(string content)
        {
            using (var barcode = new Barcode()
            {
                IncludeLabel = true,
                Alignment = AlignmentPositions.CENTER,
                Width = 250,
                Height = 100,
                RotateFlipType = RotateFlipType.RotateNoneFlipNone,
                BackColor = Color.White,
                ForeColor = Color.Black,
            })
            {
                return barcode.Encode(TYPE.CODE128B, content);
            }
        }
       /// <summary>
        /// 生成条形码
       /// </summary>
       /// <param name="content">内容</param>
       /// <param name="isIncludeLabel">是否生成条码下方标签</param>
       /// <param name="positions">布局</param>
       /// <param name="width">宽度</param>
       /// <param name="height">高度</param>
       /// <param name="backColor">背景色</param>
       /// <param name="foreColor">前景色</param>
       /// <returns></returns>
        public static Image GenerateBarCodeBitmap(string content, bool isIncludeLabel,AlignmentPositions positions,int width,int height,Color backColor,Color foreColor,RotateFlipType flipType)
        {
            using (var barcode = new Barcode()
            {
                IncludeLabel = isIncludeLabel,
                Alignment = positions,
                Width = width,
                Height = height,
                RotateFlipType = flipType,
                BackColor = backColor,
                ForeColor = foreColor
            })
            {
                return barcode.Encode(TYPE.CODE128B, content);
            }
        }
       /// <summary>
        /// 生成条形码
       /// </summary>
       /// <param name="content">内容</param>
       /// <param name="width">宽度</param>
       /// <param name="height">高度</param>
       /// <param name="backColor">背景色</param>
       /// <param name="foreColor">前景色</param>
       /// <returns></returns>
        public static Image GenerateBarCodeBitmap(string content,int width,int height,Color backColor,Color foreColor)
        {
            using (var barcode = new Barcode()
            {
                IncludeLabel = true,
                Alignment = AlignmentPositions.CENTER,
                Width = width,
                Height = height,
                RotateFlipType = RotateFlipType.RotateNoneFlipNone,
                BackColor = backColor,
                ForeColor = foreColor
            })
            {
                return barcode.Encode(TYPE.CODE128B, content);
            }
        }
        /// <summary>
        /// 生成条形码
        /// </summary>
        /// <param name="content">内容</param>
        /// <param name="width">宽度</param>
        /// <param name="height">高度</param>
        /// <param name="backColor">背景色</param>
        /// <param name="foreColor">前景色</param>
        /// <returns></returns>
        public static Image GenerateBarCodeBitmap(string content,TYPE type,int width, int height, Color backColor, Color foreColor)
        {
            using (var barcode = new Barcode()
            {
                IncludeLabel = true,
                Alignment = AlignmentPositions.CENTER,
                Width = width,
                Height = height,
                RotateFlipType = RotateFlipType.RotateNoneFlipNone,
                BackColor = backColor,
                ForeColor = foreColor
            })
            {
                return barcode.Encode(type, content);
            }
        }
        /// <summary>
        /// 生成条形码
        /// </summary>
        /// <param name="content">内容</param>
        /// <param name="width">宽度</param>
        /// <param name="height">高度</param>
        /// <param name="backColor">背景色</param>
        /// <param name="foreColor">前景色</param>
        /// <returns></returns>
        public static Image GenerateBarCodeBitmap(string content, int width, int height, RotateFlipType flipType)
        {
            using (var barcode = new Barcode()
            {
                IncludeLabel = true,
                Alignment = AlignmentPositions.CENTER,
                Width = width,
                Height = height,
                RotateFlipType = RotateFlipType.RotateNoneFlipNone,
                BackColor = Color.White,
                ForeColor = Color.Black
            })
            {
                return barcode.Encode(TYPE.CODE128B, content);
            }
        }
        /// <summary>
        /// 生成条形码
        /// </summary>
        /// <param name="content">内容</param>
        /// <param name="width">宽度</param>
        /// <param name="height">高度</param>
        /// <param name="backColor">背景色</param>
        /// <param name="foreColor">前景色</param>
        /// <returns></returns>
        public static Image GenerateBarCodeBitmap(string content, TYPE type, int width, int height, RotateFlipType flipType)
        {
            using (var barcode = new Barcode()
            {
                IncludeLabel = true,
                Alignment = AlignmentPositions.CENTER,
                Width = width,
                Height = height,
                RotateFlipType = flipType,
                BackColor = Color.White,
                ForeColor = Color.Black
            })
            {
                return barcode.Encode(type, content);
            }
        }
        /// <summary>
        /// 生成条形码
        /// </summary>
        /// <param name="content">内容</param>
        /// <param name="width">宽度</param>
        /// <param name="height">高度</param>
        /// <param name="backColor">背景色</param>
        /// <param name="foreColor">前景色</param>
        /// <returns></returns>
        public static Image GenerateBarCodeBitmap(string content,int width, int height)
        {
            using (var barcode = new Barcode()
            {
                IncludeLabel = true,
                Alignment = AlignmentPositions.CENTER,
                Width = width,
                Height = height,
                RotateFlipType = RotateFlipType.RotateNoneFlipNone,
                BackColor = Color.White,
                ForeColor = Color.Black
            })
            {
                return barcode.Encode(TYPE.CODE128B, content);
            }
        }
    }
}
