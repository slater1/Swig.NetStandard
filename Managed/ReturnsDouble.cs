//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ReturnsDouble : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ReturnsDouble(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ReturnsDouble obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ReturnsDouble() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          native_wrapPINVOKE.delete_ReturnsDouble(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }


        //public delegate double ReturnsDouble##Delegate(FOR_EACH(param, int,double));
        public delegate double ReturnsDoubleDelegate(/*@SWIG:std_function.i,26,FOR_EACH@*/ 
  int arg0, double arg1
/*@SWIG@*/);
                
        public class ConcreteDirector : ReturnsDoubleDirector
        {
            public ConcreteDirector(ReturnsDoubleDelegate f)
            {
                _f = f;
            }

            //protected override double Invoke(FOR_EACH(param, int,double))
            protected override double Invoke(/*@SWIG:std_function.i,26,FOR_EACH@*/ 
  int arg0, double arg1
/*@SWIG@*/)
            {
                return _f.Invoke(/*@SWIG:std_function.i,26,FOR_EACH@*/ 
  arg0, arg1
/*@SWIG@*/);
            }

            private readonly ReturnsDoubleDelegate _f;
        }

        public ReturnsDouble(ReturnsDoubleDelegate callback) 
        {
            _director = new ConcreteDirector(callback);
            _proxy = new ReturnsDouble(_director);
        }

        public static ReturnsDouble makeNative(ReturnsDouble f) {
            return null == f._director
                ? f
                : f._proxy;
        }

        private readonly ReturnsDoubleDirector _director;
        private readonly ReturnsDouble _proxy;
    
  public ReturnsDouble(ReturnsDouble arg0) : this(native_wrapPINVOKE.new_ReturnsDouble__SWIG_0(ReturnsDouble.getCPtr(arg0)), true) {
    if (native_wrapPINVOKE.SWIGPendingException.Pending) throw native_wrapPINVOKE.SWIGPendingException.Retrieve();
  }

  public double Invoke(int arg0, double arg1) {
    double ret = native_wrapPINVOKE.ReturnsDouble_Invoke(swigCPtr, arg0, arg1);
    return ret;
  }

  public ReturnsDouble(SWIGTYPE_p_f_int_double__double arg0) : this(native_wrapPINVOKE.new_ReturnsDouble__SWIG_1(SWIGTYPE_p_f_int_double__double.getCPtr(arg0)), true) {
  }

  public ReturnsDouble(ReturnsDoubleDirector in_) : this(native_wrapPINVOKE.new_ReturnsDouble__SWIG_2(ReturnsDoubleDirector.getCPtr(in_)), true) {
  }

}
