﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using System.IO;
using AndreaPerezSemana7.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(SQLiteClient))]

namespace AndreaPerezSemana7.Droid
{
    public class SQLiteClient : Database
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, "uisrael.db3");
            return new SQLiteAsyncConnection(path);
        }
    }
}