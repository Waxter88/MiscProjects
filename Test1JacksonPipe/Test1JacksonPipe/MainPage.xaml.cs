using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Test1JacksonPipe
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
    }

    public class Phone
    {
        public string ModelName;
        public Dimension Description;
        public Dimension.Voltage Usage;

        public Phone(string modelName, Dimension desciption, Dimension.Voltage usage)
        {
            this.ModelName = modelName;
            this.Description = desciption;
            this.Usage = usage;
        }

        public override string ToString()
        {
            return this.ModelName;
        }
        
        public virtual string GetPhoneInfo
        {
            get {
                if (this.Usage == Dimension.Voltage.V110)
                    return this.ModelName + " " + this.Description + " " + this.Usage + " US Only";
                else if (this.Usage == Dimension.Voltage.V220)
                    return this.ModelName + " " + this.Description + "" + this.Usage + " Europe Only";
                else
                    return this.ModelName + " " + this.Description + " " + this.Usage;
            } 
        }
        
    }
    public struct Dimension
    {
        double Height, Width, Depth;

        public Dimension(double height, double width, double depth)
        {
            this.Height = height;
            this.Width = width;
            this.Depth = depth;
        }

        public override string ToString()
        {
            return this.Height + "x" + this.Width + "x" + this.Depth;
        }

        public enum Voltage
        {
            V110,
            V220,
            DUAL
        }
    }

    class SmartPhone : Phone
    {
        int Storage, Cameras;
        bool isConnected;

        public SmartPhone(int storage, int camera, string modelName, Dimension desciption, Dimension.Voltage usage) : base(modelName, desciption, usage)
        {
            this.isConnected = false;
        }

        public override string ToString()
        {
            if(isConnected)
            return base.ToString() + " Connected";
            else
            return base.ToString() + " Disconnected";
        }
        public override string GetPhoneInfo
        {
            get { if (base.GetPhoneInfo != null) return base.GetPhoneInfo + this.Storage + this.Cameras;
                else return null;
            }
        }

        public string this[int index]
        {
            get { 
                if(index%2 == 0) //even
                {
                    return this.Storage.ToString();
                }else if(index%2 != 0)
                {
                    return this.Cameras.ToString();
                }
                else if(index < 0)
                {
                    throw new Exception("index cannot be negative");
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
