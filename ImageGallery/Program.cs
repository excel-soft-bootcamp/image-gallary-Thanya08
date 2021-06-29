using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageGallery
{
    class Program
    {
        static void Main(string[] args)
        {
            Gmail _mailAccount = new Gmail();
            ImageGallery mail = new ImageGallery(_mailAccount);
            mail.Share();

            Bluetooth _bluetoothDevice = new Bluetooth();
            ImageGallery bluetooth = new ImageGallery(_bluetoothDevice);
            bluetooth.Share();

            Whatsapp messenger = new Whatsapp();
            ImageGallery _messenger = new ImageGallery(messenger);
            _messenger.Share();

        }
    }

 }
    

