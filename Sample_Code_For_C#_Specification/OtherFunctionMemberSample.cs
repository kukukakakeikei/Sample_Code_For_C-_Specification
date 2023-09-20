using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleOtherFunction
{
    internal class OtherFunctionMemberSample
    {
    }

    public class List<T>
    {
        /// <summary>
        /// 常量
        /// </summary>
        const int defaultCapacity = 4;
        T[] items;
        int count;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="capacity"></param>
        public List(int capacity = defaultCapacity)
        {
            items = new T[capacity];
        }
        /// <summary>
        /// 属性
        /// </summary>
        public int Count
        {
            get { return count; }//只读属性
        }
        public int Capacity
        {
            get { return items.Length; }//读写属性
            set
            {
                if (value < count) value = count;
                if (value != items.Length)
                {
                    T[] newItems = new T[value];
                    Array.Copy(items, 0, newItems, 0, count);
                    items = newItems;
                }
            }
        }
        /// <summary>
        /// 索引器
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T this[int index]
        {
            get { return items[index]; }
            set
            {
                items[index] = value;
                OnChanged();
            }
        }
        /// <summary>
        /// 方法
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            if (count == Capacity) Capacity = count * 2;
            items[count] = item;
            count++;
            OnChanged();
        }
        protected virtual void OnChanged()
        {
            if (Changed != null) Changed(this, EventArgs.Empty);//虚方法
        }
        public override bool Equals(object other)
        {
            return Equals(this, other as List<T>);
        }
        static bool Equals(List<T> a, List<T> b)
        {
            if (a == null) return b == null;
            if (b == null || a.count != b.Count) return false;
            for (int i = 0; i < a.Count; i++)
            {
                if (!object.Equals(a.items[i], b.items[i]))
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// 事件
        /// </summary>
        public event EventHandler Changed;
        /// <summary>
        /// 运算符
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator ==(List<T> a, List<T> b)
        {
            return Equals(a, b);
        }
        public static bool operator !=(List<T> a, List<T> b)
        {
            return !Equals(a, b);
        }
    }
}
