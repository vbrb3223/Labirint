using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Лабиринт__11
{
    public class ImageCollection
    {
        public List<ImageSource> EnviromentBlocks = new List<ImageSource>()
        {
            new BitmapImage(new Uri(@"pack://application:,,,/Resources/grassForLabirint.jpg")),
            new BitmapImage(new Uri(@"pack://application:,,,/Resources/box.jpg")),
            new BitmapImage(new Uri(@"pack://application:,,,/Resources/finishForLabirint.jpg")),
            new BitmapImage(new Uri(@"pack://application:,,,/Resources/headForLabirint.jpg")),
            new BitmapImage(new Uri(@"pack://application:,,,/Resources/press.png")),
            new BitmapImage(new Uri(@"pack://application:,,,/Resources/startForLabirint.jpg")),
            new BitmapImage(new Uri(@"pack://application:,,,/Resources/wallForLabirint.jpg"))
        };

        public ImageBrush this[string name]
        {
            get
            {
                switch (name)
                {
                    case "grass":
                        return new ImageBrush { ImageSource = EnviromentBlocks[0] };
                    case "box":
                        return new ImageBrush { ImageSource = EnviromentBlocks[1] };
                    case "finish":
                        return new ImageBrush { ImageSource = EnviromentBlocks[2] };
                    case "head":
                        return new ImageBrush { ImageSource = EnviromentBlocks[3] };
                    case "press":
                        return new ImageBrush { ImageSource = EnviromentBlocks[4] };
                    case "start":
                        return new ImageBrush { ImageSource = EnviromentBlocks[5] };
                    default:
                        return new ImageBrush { ImageSource = EnviromentBlocks[6] };
                }
            }
        }

        public ImageBrush this[int index]
        {
            get
            {
                if (index >= 0 && index < EnviromentBlocks.Count)
                    return new ImageBrush { ImageSource = EnviromentBlocks[index] };
                else
                    return new ImageBrush { ImageSource = EnviromentBlocks[6] };
            }
        }
    }
}
