using NUnit.Framework;

namespace Tests
{
    public class SwigTests
    {
        /// <summary>
        /// Verify that a C# object initializer sets a C++ class member.
        /// </summary>
        [Test]
        public void Cs_ObjectInitializer_Sets_Cpp_ClassMember()
        {
            var hasTest = new HasTest(new Test { Value = 5 });

            Assert.AreEqual(5, hasTest.GetValue());
        }

        /// <summary>
        /// Verify that C# can call a C++ class member function
        /// </summary>
        [Test]
        public void Cs_Calls_Cpp_ClassMember()
        {
            var hasTest = new HasTest(new Test());

            hasTest.SetValue(6);
            Assert.AreEqual(6, hasTest.GetValue());
        }

        /// <summary>
        /// Verify that Swig Director enables cross-language inheritance,
        /// i.e. a base C++ class member calls a derived C# class member
        /// </summary>
        [Test]
        public void Cpp_Calls_Cs_ClassMember()
        {
            var hasTest = new HasTest(new DerivedTest());

            hasTest.SetValue(4);
            Assert.AreEqual(8, hasTest.GetValue());
        }

        /// <summary>
        /// Verify that a SWIG callback returning void can be called in C#
        /// </summary>
        [Test]
        public void Cs_Calls_Swig_Nonvoid_Function()
        {
            double result = native_wrap.add(1, 2.1);
            Assert.AreEqual(3.1, result);
        }

        /// <summary>
        /// Verify that a SWIG callback returning a value can be called in C#
        /// </summary>
        [Test]
        public void Cs_Calls_Swig_Nonvoid_Callback()
        {
            double result = new ReturnsDouble(native_wrap.add_cb).Invoke(2, 2.2);
            Assert.AreEqual(4.2, result);
        }

        /// <summary>
        /// Verify that std::function taking std::shared_ptr to a const pointer can be called in C#
        /// </summary>
        [Test]
        public void Cs_Calls_shared_pointer_to_const()
        {
            var output = native_wrap.test_shared_ptr().Invoke(new Input { Value = "test" });
            Assert.AreEqual("test", output.Input.Value);
        }

        /// <summary>
        /// Verify that std::function created in C++ can be called in C#
        /// </summary>
        [Test]
        public void Cs_Calls_std_function_Void_Callback()
        {
            native_wrap.make_set_string_side_effect_callback().Invoke("test");
            Assert.AreEqual("test", native_wrap.string_side_effect);
        }

        /// <summary>
        /// Verify that std::function created in C++ can be called in C#
        /// </summary>
        [Test]
        public void Cs_Calls_std_function_Callback()
        {
            native_wrap.make_add_set_double_side_effect_callback().Invoke(1, 2.5);
            Assert.AreEqual(3.5, native_wrap.double_side_effect);
        }

        /// <summary>
        /// Verify that C++ can call a C# callback
        /// </summary>
        [Test]
        public void Cpp_Calls_Cs_Callback()
        {
            var result = native_wrap.invoke_callback(new ReturnsDouble((i, d) => i + d));
            Assert.AreEqual(1 + 2.5, result); // Value set in native.i
        }

        /// <summary>
        /// Verify that a C++ std::function mapped to a C# delegate maps back to an std::function
        /// </summary>
        [Test]
        public void Callback_Makes_Roundtrip()
        {
            var callback = native_wrap.make_add_set_double_side_effect_callback();
            var result = native_wrap.invoke_callback(callback);
            Assert.AreEqual(native_wrap.double_side_effect, result); // Value set in native.i
        }
    }

    class DerivedTest : Test
    {
        public override void SetValue(int value)
        {
            _myValue = 2 * value;
        }

        public override int GetValue()
        {
            return _myValue;
        }

        private int _myValue = 0;
    }
}