using ForVacancy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestFixture]
    class TestMyCollectionException
    {
        [Test]
        public void Test_MyCollectionMethod_Current_Exception()
        {
            try
            {
                MyCollection<Person> people = new MyCollection<Person>();
                var element = people.Current;
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Список MyCollection пуст");
            }
        }
       
        [Test]
        public void Test_MyCollectionMethod_Previous_Exception()
        {
            try
            {
                MyCollection<Person> people = new MyCollection<Person>();
                var element = people.Previous;
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Список MyCollection пуст");
            }
        }
        [Test]
        public void Test_MyCollectionMethod_Next_Exception()
        {
            try
            {
                MyCollection<Person> people = new MyCollection<Person>();
                var element = people.Next;
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Список MyCollection пуст");
            }
        }
        [Test]
        public void Test_MyCollectionMethod_MoveNext_Exception()
        {
            try
            {
                MyCollection<Person> people = new MyCollection<Person>();
                people.MoveNext();
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Список MyCollection пуст");
            }
        }
        [Test]
        public void Test_MyCollectionMethod_MoveBack_Exception()
        {
            try
            {
                MyCollection<Person> people = new MyCollection<Person>();
                people.MoveBack();
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Список MyCollection пуст");
            }
        }

        [Test]
        public void Test_MyCollectionMethod_SetValueNullOfRange_Exception()
        {
            try
            {
                MyCollection<Person> people = new MyCollection<Person>();
                people[0] = new Person { num = 41 };
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Список MyCollection пуст");
            }
        }

        [Test]
        public void Test_MyCollectionMethod_SetValueLessZeroIndex_Exception()
        {
            try
            {
                MyCollection<Person> people = new MyCollection<Person>();
                Person person1 = new Person() { num = 10 };
                Person person2 = new Person() { num = 20 };
                Person person3 = new Person() { num = 30 };
                people.Add(person1);
                people.Add(person2);
                people.Add(person3);
                people[-2] = new Person { num = 41 };
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "index должен быть больше или равен 0");
            }
        }
            [Test]
        public void Test_MyCollectionMethod_SetValueOutOfRange_Exception()
        {
            try
            {
                MyCollection<Person> people = new MyCollection<Person>();
                Person person1 = new Person() { num = 10 };
                Person person2 = new Person() { num = 20 };
                Person person3 = new Person() { num = 30 };
                people.Add(person1);
                people.Add(person2);
                people.Add(person3);
                people[4] = new Person { num = 41 };
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "index должен быть меньше или равен 2");
            }
                       
        }
        [Test]
        public void Test_MyCollectionMethod_GetValueLessZeroIndex_Exception()
        {
            try
            {
                MyCollection<Person> people = new MyCollection<Person>();
                Person person1 = new Person() { num = 10 };
                Person person2 = new Person() { num = 20 };
                Person person3 = new Person() { num = 30 };
                people.Add(person1);
                people.Add(person2);
                people.Add(person3);
                var element = people[-2];
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "index должен быть больше или равен 0");
            }
        }
        [Test]
        public void Test_MyCollectionMethod_GetValueNullOfRange_Exception()
        {
            try
            {
                MyCollection<Person> people = new MyCollection<Person>();
                Person person1 = new Person() { num = 10 };
                Person person2 = new Person() { num = 20 };
                Person person3 = new Person() { num = 30 };
                var element = people[0];
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Список MyCollection пуст");
            }
        }
            [Test]
        public void Test_MyCollectionMethod_GetValueOutOfRange_Exception()
        {
            try
            {
                MyCollection<Person> people = new MyCollection<Person>();
                Person person1 = new Person() { num = 10 };
                Person person2 = new Person() { num = 20 };
                Person person3 = new Person() { num = 30 };
                people.Add(person1);
                people.Add(person2);
                people.Add(person3);
                var element = people[4];
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "index должен быть меньше или равен 2");
            }
        }
        [Test]
        public void Test_MyCollectionMethod_IndexOf_Exception()
        {
            try
            {
                MyCollection<Person> people = new MyCollection<Person>();
                Person person1 = new Person() { num = 10 };
                Person person2 = new Person() { num = 20 };
                Person person3 = new Person() { num = 30 };
                
                var element = people.IndexOf(person1);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Список MyCollection пуст");
            }
        }

        [Test]
        public void Test_MyCollectionMethod_RemoveAtIndexNull_Exception()
        {
            try
            {
                MyCollection<Person> people = new MyCollection<Person>();
                Person person1 = new Person() { num = 10 };
                Person person2 = new Person() { num = 20 };
                Person person3 = new Person() { num = 30 };
                people.RemoveAt(0);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Список MyCollection пуст");
            }
        }

        [Test]
        public void Test_MyCollectionMethod_RemoveAtIndexMoreListCount_Exception()
        {
            try
            {
                MyCollection<Person> people = new MyCollection<Person>();
                Person person1 = new Person() { num = 10 };
                Person person2 = new Person() { num = 20 };
                Person person3 = new Person() { num = 30 };
                people.Add(person1);
                people.Add(person2);
                people.Add(person3);
                people.RemoveAt(4);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "индекс не должен превышать размер списка 2");
            }
        }
        [Test]
        public void Test_MyCollectionMethod_RemoveAtIndexLessZero_Exception()
        {
            try
            {
                MyCollection<Person> people = new MyCollection<Person>();
                Person person1 = new Person() { num = 10 };
                Person person2 = new Person() { num = 20 };
                Person person3 = new Person() { num = 30 };
                people.Add(person1);
                people.Add(person2);
                people.Add(person3);
                people.RemoveAt(-2);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "индекс не может быть меньше 0");
            }
        }

        [Test]
        public void Test_MyCollectionMethod_Clear_Exception()
        {
            try
            {
                MyCollection<Person> people = new MyCollection<Person>();
                people.Clear();
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Список MyCollection пуст");
            }
        }
        [Test]
        public void Test_MyCollectionMethod_Contains_Exception()
        {
            try
            {
                MyCollection<Person> people = new MyCollection<Person>();
                Person person1 = new Person() { num = 10 };
                people.Contains(person1);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Список MyCollection пуст");
            }
        }
    }
}
