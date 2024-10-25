﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Aprogram
{
    public class ContentLoader : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        public ContentLoader()
        {
            Visibility = Visibility.Collapsed;
        }

        Visibility visibility;
        public Visibility Visibility
        {
            get { return visibility; }
            set { visibility = value; NotifyPropertyChanged("Visibility"); }
        }

        public void LoadContent()
        {

            Visibility = Visibility.Visible;

            var t = new Thread(() =>
            {
                Thread.Sleep(200);

                Visibility = Visibility.Collapsed;
            });

            t.Start();
        }
    }
}
