// using System;
// using System.Collections;
//
// namespace Lab9
// {
//     public class Lmist<T> : IEnumerable
//     {
//         private IEnumerable _enumerableImplementation;
//         public Software<T> Head { get; private set; }
//         public Software<T> Tail { get; private set; }
//         public int Count { get; private set; }
//
//         public Lmist()
//         {
//             Head = null;
//             Tail = null;
//             Count = 0;
//         }
//
//         public Lmist(T softName)
//         {
//             Software<T> soft = new Software<T>(softName);
//             Head = soft;
//             Tail = soft;
//             Count = 1;
//         }
//
//         public void Add(T softName)
//         {
//             Software<T> soft = new Software<T>(softName);
//             if (Tail != null)
//             {
//                 Tail.Next = soft;
//                 Tail = soft;
//                 Count++;
//             }
//             else
//             {
//                 Head = soft;
//                 Tail = soft;
//                 Count = 1;
//             }
//         }
//
//         public void Delete(T softName)
//         {
//             if (Head != null)
//             {
//                 if (Head.SoftName.Equals(softName))
//                 {
//                     Head = Head.Next;
//                     Count--;
//                     return;
//                 }
//                 Software<T> current = Head.Next;
//                 Software<T> previous = Head;
//                 while (current.Next != null)
//                 {
//                     if (current.SoftName.Equals(softName))
//                     {
//                         previous.Next = current.Next;
//                         Count--;
//                         return;
//                     }
//                     previous = current;
//                     current = current.Next;
//                 }
//             }
//         }
//
//         public void Clear()
//         {
//             Head = null;
//             Tail = null;
//             Count = 0;
//         }
//
//         public IEnumerator GetEnumerator()
//         {
//             Software<T> current = Head;
//             while (current != null)
//             {
//                 yield return current.SoftName;
//                 current = current.Next;
//             }
//         }
//
//         public override string ToString()
//         {
//             return "\nList with " + Count + " elements";
//         }
//     }
// }
