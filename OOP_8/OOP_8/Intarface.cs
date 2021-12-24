using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_8
{
    public interface InterfaceGeneric<T>
    {
        void Add(T number);
        void Delete(T number);
        void Show();
    }
}
