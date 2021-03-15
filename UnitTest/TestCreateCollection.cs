using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForVacancy;

namespace UnitTest
{
    [TestFixture]
    class TestCreateCollection
    {
        [Test]
        public void Test_MyCollectionMethod_Current()
        {
            MyCollection<Person> people = new MyCollection<Person>();
            Person person1 = new Person() { num = 1 };
            Person person2 = new Person() { num = 2 };
            people.Add(person1);
            people.Add(person2);
            Assert.AreEqual(people.Current.num, 1);
        }
        [Test]
        public void Test_MyCollectionMethod_MoveNext()
        {
            MyCollection<Person> people = new MyCollection<Person>();
            Person person1 = new Person() { num = 1 };
            Person person2 = new Person() { num = 2 };
            Person person3 = new Person() { num = 3 };
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            Assert.AreEqual(people.Current.num, 1);
            people.MoveNext();
            Assert.AreEqual(people.Current.num, 2);
            people.MoveNext();
            Assert.AreEqual(people.Current.num, 3);
            people.MoveNext();
            Assert.AreEqual(people.Current.num, 1);
        }

        [Test]
        public void Test_MyCollectionMethod_MoveBack()
        {
            MyCollection<Person> people = new MyCollection<Person>();
            Person person1 = new Person() { num = 1 };
            Person person2 = new Person() { num = 2 };
            Person person3 = new Person() { num = 3 };
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            Assert.AreEqual(people.Current.num, 1);
            people.MoveBack();
            Assert.AreEqual(people.Current.num, 3);
            people.MoveBack();
            Assert.AreEqual(people.Current.num, 2);
            people.MoveBack();
            Assert.AreEqual(people.Current.num, 1);
        }

        [Test]
        public void Test_MyCollectionMethod_Previous()
        {
            MyCollection<Person> people = new MyCollection<Person>();
            Person person1 = new Person() { num = 10 };
            Person person2 = new Person() { num = 20 };
            Person person3 = new Person() { num = 30 };
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            Assert.AreEqual(people.Previous.num, 30);
            people.MoveBack();
            Assert.AreEqual(people.Previous.num, 20);
            people.MoveBack();
            Assert.AreEqual(people.Previous.num, 10);
            people.MoveNext();
            Assert.AreEqual(people.Previous.num, 20);
        }
        [Test]
        public void Test_MyCollectionMethod_Next()
        {
            MyCollection<Person> people = new MyCollection<Person>();
            Person person1 = new Person() { num = 10 };
            Person person2 = new Person() { num = 20 };
            Person person3 = new Person() { num = 30 };
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            Assert.AreEqual(people.Next.num, 20);
            people.MoveBack();
            Assert.AreEqual(people.Next.num, 10);
            people.MoveBack();
            Assert.AreEqual(people.Next.num, 30);
            people.MoveNext();
            Assert.AreEqual(people.Next.num, 10);
        }
        [Test]
        public void Test_MyCollectionMethod_IndexOf()
        {
            MyCollection<Person> people = new MyCollection<Person>();
            Person person1 = new Person() { num = 10 };
            Person person2 = new Person() { num = 20 };
            Person person3 = new Person() { num = 30 };
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            Assert.AreEqual(people.IndexOf(person1), 0);
            Assert.AreEqual(people.IndexOf(person3), 2);
            Assert.AreEqual(people.IndexOf(person2), 1);
        }
        [Test]
        public void Test_MyCollectionMethod_Insert()
        {
            MyCollection<Person> people = new MyCollection<Person>();
            Person person1 = new Person() { num = 10 };
            Person person2 = new Person() { num = 20 };
            Person person3 = new Person() { num = 30 };
            Person person4 = new Person() { num = 40 };
            Person person5 = new Person() { num = 50 };
            people.Add(person1);
            people.Add(person2);
            people.Insert(0, person4);
            people.Insert(1, person5);
            people.Insert(2, person3);
            Assert.AreEqual(people.IndexOf(person4), 0);
            Assert.AreEqual(people.IndexOf(person5), 1);
            Assert.AreEqual(people.IndexOf(person3), 2);
            Assert.AreEqual(people.IndexOf(person1), 3);
            Assert.AreEqual(people.IndexOf(person2), 4);
        }
        [Test]
        public void Test_MyCollectionMethod_RemoveAt()
        {
            MyCollection<Person> people = new MyCollection<Person>();
            Person person1 = new Person() { num = 10 };
            Person person2 = new Person() { num = 20 };
            Person person3 = new Person() { num = 30 };
            Person person4 = new Person() { num = 40 };
            Person person5 = new Person() { num = 50 };
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);
            Assert.AreEqual(people.Count, 4);
            people.RemoveAt(0);
            Assert.AreEqual(people.Count, 3);
            people.RemoveAt(2);
            Assert.AreEqual(people.Count, 2);
            people.RemoveAt(1);
            Assert.AreEqual(people.Count, 1);
            people.RemoveAt(0);
            Assert.AreEqual(people.Count, 0);
        }

        [Test]
        public void Test_MyCollectionMethod_RemoveAt_ChangePosition()
        {
            MyCollection<Person> people = new MyCollection<Person>();
            Person person1 = new Person() { num = 10 };
            Person person2 = new Person() { num = 20 };
            Person person3 = new Person() { num = 30 };
            Person person4 = new Person() { num = 40 };
            Person person5 = new Person() { num = 50 };
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);
            people.MoveNext();
            people.MoveNext();
            Assert.AreEqual(people.Current, person3);
            Assert.AreEqual(people.IndexOf(person3), 2);
            people.RemoveAt(0);
            Assert.AreEqual(people.Current, person3);
            Assert.AreEqual(people.IndexOf(person3), 1);
        }

        [Test]
        public void Test_MyCollectionMethod_Remove_ChangePosition()
        {
            MyCollection<Person> people = new MyCollection<Person>();
            Person person1 = new Person() { num = 10 };
            Person person2 = new Person() { num = 20 };
            Person person3 = new Person() { num = 30 };
            Person person4 = new Person() { num = 40 };
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);
            people.MoveNext();
            people.MoveNext();
            Assert.AreEqual(people.Current, person3);
            Assert.AreEqual(people.IndexOf(person3), 2);
            people.Remove(person1);
            Assert.AreEqual(people.Current, person3);
            Assert.AreEqual(people.IndexOf(person3), 1);
        }
            [Test]
        public void Test_MyCollectionMethod_Remove()
        {
            MyCollection<Person> people = new MyCollection<Person>();
            Person person1 = new Person() { num = 10 };
            Person person2 = new Person() { num = 20 };
            Person person3 = new Person() { num = 30 };
            Person person4 = new Person() { num = 40 };
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);
            Assert.AreEqual(people.Count, 4);
            people.Remove(person1);
            Assert.AreEqual(people.Count, 3);
            people.Remove(person4);
            Assert.AreEqual(people.Count, 2);
            people.Remove(person3);
            Assert.AreEqual(people.Count, 1);
            people.Remove(person2);
            Assert.AreEqual(people.Count, 0);
        }
      
        [Test]
        public void Test_MyCollectionMethod_Clear()
        {
            MyCollection<Person> people = new MyCollection<Person>();
            Person person1 = new Person() { num = 10 };
            Person person2 = new Person() { num = 20 };
            Person person3 = new Person() { num = 30 };
            Person person4 = new Person() { num = 40 };
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);
            Assert.AreEqual(people.Count, 4);
            people.Clear();
            Assert.AreEqual(people.Count, 0);
        }
        [Test]
        public void Test_MyCollectionMethod_Contains()
        {
            MyCollection<Person> people = new MyCollection<Person>();
            Person person1 = new Person() { num = 10 };
            Person person2 = new Person() { num = 20 };
            Person person3 = new Person() { num = 30 };
            Person person4 = new Person() { num = 40 };
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            Assert.AreEqual(people.Contains(person3), true);
            Assert.AreEqual(people.Contains(person1), true);
            Assert.AreEqual(people.Contains(person4), false);
        }

    }
}
