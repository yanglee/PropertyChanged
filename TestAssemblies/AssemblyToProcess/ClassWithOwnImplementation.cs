﻿using System.ComponentModel;

public class ClassWithOwnImplementation : INotifyPropertyChanged
{
    public string Property1 { get; set; }
    public bool BaseNotifyCalled { get; set; }

    public event PropertyChangedEventHandler PropertyChanged;

    public virtual void OnPropertyChanged(string propertyName)
    {
        BaseNotifyCalled = true;
        var handler = PropertyChanged;
        if (handler != null)
        {
            handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}