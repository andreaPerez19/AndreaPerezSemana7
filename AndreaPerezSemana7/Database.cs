using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace AndreaPerezSemana7
{
    public interface Database
    {
        SQLiteAsyncConnection GetConnection();
    }
}
