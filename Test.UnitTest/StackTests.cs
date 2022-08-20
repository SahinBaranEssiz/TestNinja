using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace Test.UnitTest
{
    public class StackTests
    {
        [Test]
        public void StackPush_ObjIsNull_ThrowArgumentNullException()
        {
            //eğer obje boşsa null exception atıyor
            var stack = new TestNinja.Fundamentals.Stack<string>();
            Assert.That(() => stack.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        public void StackPush_ValidArg_AddTheObjectToTheStack()
        {
            //eğer 1 ürün girildiyse stok 1 olmalı 
            var stack = new TestNinja.Fundamentals.Stack<string>();

            stack.Push("a");

            Assert.That(stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void StackCount_EmptyStack_ReturnZero()
        {
            //eğer stok girilmediyse 0 dönmeli
            var stack = new TestNinja.Fundamentals.Stack<string>();

            Assert.That(stack.Count, Is.EqualTo(0));
        }

        [Test]
        public void StackPop_EmptyStack_ThrowInvalidOperationException()
        {
            //liste 0 ise InvalidOperationException işlemini gerçekleştirmeli
            var stack = new TestNinja.Fundamentals.Stack<string>();

            Assert.That(() => stack.Pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void StackPop_StackWithAFewObjects_ReturnObjectOnTheTop()
        {
            //En üstteki objeyi test ediyor
            var stack = new TestNinja.Fundamentals.Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

           
            var result = stack.Pop();

            
            Assert.That(result, Is.EqualTo("c"));
        }

        [Test]
        public void Pop_StackWithAFewObjects_RemoveObjectOnTheTop()
        {
            //kaç adet obje olduğunu test ediyor
            var stack = new TestNinja.Fundamentals.Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            stack.Pop();

            Assert.That(stack.Count, Is.EqualTo(2));
        }

        [Test]
        public void StackPeek_EmptyStack_ThrowInvalidOperationException()
        {
            //invalid değer girilince InvalidOperationException atması gerekiyor
            var stack = new TestNinja.Fundamentals.Stack<string>();

            Assert.That(() => stack.Peek(), Throws.InvalidOperationException);
        }

        [Test]
        public void Peek_StackWithObjects_ReturnObjectOnTopOfTheStack()
        {
            //son değerin gelip gelmediği test ediliyor
            var stack = new TestNinja.Fundamentals.Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            var result = stack.Peek();

            Assert.That(result, Is.EqualTo("c"));
        }

        [Test]
        public void Peek_StackWithObjects_DoesNotRemoveTheObjectOnTopOfTheStack()
        {
            //yüklenen 3 değerin yüklenip yüklenmediğini test ediyor
            var stack = new TestNinja.Fundamentals.Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            stack.Peek();

            Assert.That(stack.Count, Is.EqualTo(3));
        }



    }
}
