//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ReturnsSharedPtr : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ReturnsSharedPtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ReturnsSharedPtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ReturnsSharedPtr() {
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
          native_wrapPINVOKE.delete_ReturnsSharedPtr(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }


        //public delegate std::shared_ptr<Output> ReturnsSharedPtr##Delegate(FOR_EACH(param, const Input*));
        public delegate Output ReturnsSharedPtrDelegate(/*@SWIG:std_function.i,26,FOR_EACH@*/ 
  Input arg0
/*@SWIG@*/);
                
        public class ConcreteDirector : ReturnsSharedPtrDirector
        {
            public ConcreteDirector(ReturnsSharedPtrDelegate f)
            {
                _f = f;
            }

            //protected override std::shared_ptr<Output> Invoke(FOR_EACH(param, const Input*))
            protected override Output Invoke(/*@SWIG:std_function.i,26,FOR_EACH@*/ 
  Input arg0
/*@SWIG@*/)
            {
                return _f.Invoke(/*@SWIG:std_function.i,26,FOR_EACH@*/ 
  arg0
/*@SWIG@*/);
            }

            private readonly ReturnsSharedPtrDelegate _f;
        }

        public ReturnsSharedPtr(ReturnsSharedPtrDelegate callback) 
        {
            _director = new ConcreteDirector(callback);
            _proxy = new ReturnsSharedPtr(_director);
        }

        public static ReturnsSharedPtr makeNative(ReturnsSharedPtr f) {
            return null == f._director
                ? f
                : f._proxy;
        }

        private readonly ReturnsSharedPtrDirector _director;
        private readonly ReturnsSharedPtr _proxy;
    
  public ReturnsSharedPtr(ReturnsSharedPtr arg0) : this(native_wrapPINVOKE.new_ReturnsSharedPtr__SWIG_0(ReturnsSharedPtr.getCPtr(arg0)), true) {
    if (native_wrapPINVOKE.SWIGPendingException.Pending) throw native_wrapPINVOKE.SWIGPendingException.Retrieve();
  }

  public Output Invoke(Input arg0) {
    global::System.IntPtr cPtr = native_wrapPINVOKE.ReturnsSharedPtr_Invoke(swigCPtr, Input.getCPtr(arg0));
    Output ret = (cPtr == global::System.IntPtr.Zero) ? null : new Output(cPtr, true);
    return ret;
  }

  public ReturnsSharedPtr(SWIGTYPE_p_f_p_q_const__Input__std__shared_ptrT_Output_t arg0) : this(native_wrapPINVOKE.new_ReturnsSharedPtr__SWIG_1(SWIGTYPE_p_f_p_q_const__Input__std__shared_ptrT_Output_t.getCPtr(arg0)), true) {
  }

  public ReturnsSharedPtr(ReturnsSharedPtrDirector in_) : this(native_wrapPINVOKE.new_ReturnsSharedPtr__SWIG_2(ReturnsSharedPtrDirector.getCPtr(in_)), true) {
  }

}
