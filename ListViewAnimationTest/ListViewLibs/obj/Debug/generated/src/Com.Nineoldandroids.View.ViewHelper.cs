using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nineoldandroids.View {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewHelper']"
	[global::Android.Runtime.Register ("com/nineoldandroids/view/ViewHelper", DoNotGenerateAcw=true)]
	public sealed partial class ViewHelper : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewHelper.Honeycomb']"
		[global::Android.Runtime.Register ("com/nineoldandroids/view/ViewHelper$Honeycomb", DoNotGenerateAcw=true)]
		public sealed partial class Honeycomb : global::Java.Lang.Object {

			internal Honeycomb (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nineoldandroids/view/ViewHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ViewHelper); }
		}

		internal ViewHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getAlpha_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewHelper']/method[@name='getAlpha' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getAlpha", "(Landroid/view/View;)F", "")]
		public static unsafe float GetAlpha (global::Android.Views.View p0)
		{
			if (id_getAlpha_Landroid_view_View_ == IntPtr.Zero)
				id_getAlpha_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "getAlpha", "(Landroid/view/View;)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_getAlpha_Landroid_view_View_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getPivotX_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewHelper']/method[@name='getPivotX' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getPivotX", "(Landroid/view/View;)F", "")]
		public static unsafe float GetPivotX (global::Android.Views.View p0)
		{
			if (id_getPivotX_Landroid_view_View_ == IntPtr.Zero)
				id_getPivotX_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "getPivotX", "(Landroid/view/View;)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_getPivotX_Landroid_view_View_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getPivotY_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewHelper']/method[@name='getPivotY' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getPivotY", "(Landroid/view/View;)F", "")]
		public static unsafe float GetPivotY (global::Android.Views.View p0)
		{
			if (id_getPivotY_Landroid_view_View_ == IntPtr.Zero)
				id_getPivotY_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "getPivotY", "(Landroid/view/View;)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_getPivotY_Landroid_view_View_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getRotation_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewHelper']/method[@name='getRotation' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getRotation", "(Landroid/view/View;)F", "")]
		public static unsafe float GetRotation (global::Android.Views.View p0)
		{
			if (id_getRotation_Landroid_view_View_ == IntPtr.Zero)
				id_getRotation_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "getRotation", "(Landroid/view/View;)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_getRotation_Landroid_view_View_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getRotationX_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewHelper']/method[@name='getRotationX' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getRotationX", "(Landroid/view/View;)F", "")]
		public static unsafe float GetRotationX (global::Android.Views.View p0)
		{
			if (id_getRotationX_Landroid_view_View_ == IntPtr.Zero)
				id_getRotationX_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "getRotationX", "(Landroid/view/View;)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_getRotationX_Landroid_view_View_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getRotationY_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewHelper']/method[@name='getRotationY' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getRotationY", "(Landroid/view/View;)F", "")]
		public static unsafe float GetRotationY (global::Android.Views.View p0)
		{
			if (id_getRotationY_Landroid_view_View_ == IntPtr.Zero)
				id_getRotationY_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "getRotationY", "(Landroid/view/View;)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_getRotationY_Landroid_view_View_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getScaleX_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewHelper']/method[@name='getScaleX' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getScaleX", "(Landroid/view/View;)F", "")]
		public static unsafe float GetScaleX (global::Android.Views.View p0)
		{
			if (id_getScaleX_Landroid_view_View_ == IntPtr.Zero)
				id_getScaleX_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "getScaleX", "(Landroid/view/View;)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_getScaleX_Landroid_view_View_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getScaleY_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewHelper']/method[@name='getScaleY' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getScaleY", "(Landroid/view/View;)F", "")]
		public static unsafe float GetScaleY (global::Android.Views.View p0)
		{
			if (id_getScaleY_Landroid_view_View_ == IntPtr.Zero)
				id_getScaleY_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "getScaleY", "(Landroid/view/View;)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_getScaleY_Landroid_view_View_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getScrollX_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewHelper']/method[@name='getScrollX' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getScrollX", "(Landroid/view/View;)F", "")]
		public static unsafe float GetScrollX (global::Android.Views.View p0)
		{
			if (id_getScrollX_Landroid_view_View_ == IntPtr.Zero)
				id_getScrollX_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "getScrollX", "(Landroid/view/View;)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_getScrollX_Landroid_view_View_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getScrollY_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewHelper']/method[@name='getScrollY' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getScrollY", "(Landroid/view/View;)F", "")]
		public static unsafe float GetScrollY (global::Android.Views.View p0)
		{
			if (id_getScrollY_Landroid_view_View_ == IntPtr.Zero)
				id_getScrollY_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "getScrollY", "(Landroid/view/View;)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_getScrollY_Landroid_view_View_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getTranslationX_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewHelper']/method[@name='getTranslationX' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getTranslationX", "(Landroid/view/View;)F", "")]
		public static unsafe float GetTranslationX (global::Android.Views.View p0)
		{
			if (id_getTranslationX_Landroid_view_View_ == IntPtr.Zero)
				id_getTranslationX_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "getTranslationX", "(Landroid/view/View;)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_getTranslationX_Landroid_view_View_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getTranslationY_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewHelper']/method[@name='getTranslationY' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getTranslationY", "(Landroid/view/View;)F", "")]
		public static unsafe float GetTranslationY (global::Android.Views.View p0)
		{
			if (id_getTranslationY_Landroid_view_View_ == IntPtr.Zero)
				id_getTranslationY_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "getTranslationY", "(Landroid/view/View;)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_getTranslationY_Landroid_view_View_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getX_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewHelper']/method[@name='getX' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getX", "(Landroid/view/View;)F", "")]
		public static unsafe float GetX (global::Android.Views.View p0)
		{
			if (id_getX_Landroid_view_View_ == IntPtr.Zero)
				id_getX_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "getX", "(Landroid/view/View;)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_getX_Landroid_view_View_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getY_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewHelper']/method[@name='getY' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getY", "(Landroid/view/View;)F", "")]
		public static unsafe float GetY (global::Android.Views.View p0)
		{
			if (id_getY_Landroid_view_View_ == IntPtr.Zero)
				id_getY_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "getY", "(Landroid/view/View;)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_getY_Landroid_view_View_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setAlpha_Landroid_view_View_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewHelper']/method[@name='setAlpha' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='float']]"
		[Register ("setAlpha", "(Landroid/view/View;F)V", "")]
		public static unsafe void SetAlpha (global::Android.Views.View p0, float p1)
		{
			if (id_setAlpha_Landroid_view_View_F == IntPtr.Zero)
				id_setAlpha_Landroid_view_View_F = JNIEnv.GetStaticMethodID (class_ref, "setAlpha", "(Landroid/view/View;F)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setAlpha_Landroid_view_View_F, __args);
			} finally {
			}
		}

		static IntPtr id_setPivotX_Landroid_view_View_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewHelper']/method[@name='setPivotX' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='float']]"
		[Register ("setPivotX", "(Landroid/view/View;F)V", "")]
		public static unsafe void SetPivotX (global::Android.Views.View p0, float p1)
		{
			if (id_setPivotX_Landroid_view_View_F == IntPtr.Zero)
				id_setPivotX_Landroid_view_View_F = JNIEnv.GetStaticMethodID (class_ref, "setPivotX", "(Landroid/view/View;F)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setPivotX_Landroid_view_View_F, __args);
			} finally {
			}
		}

		static IntPtr id_setPivotY_Landroid_view_View_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewHelper']/method[@name='setPivotY' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='float']]"
		[Register ("setPivotY", "(Landroid/view/View;F)V", "")]
		public static unsafe void SetPivotY (global::Android.Views.View p0, float p1)
		{
			if (id_setPivotY_Landroid_view_View_F == IntPtr.Zero)
				id_setPivotY_Landroid_view_View_F = JNIEnv.GetStaticMethodID (class_ref, "setPivotY", "(Landroid/view/View;F)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setPivotY_Landroid_view_View_F, __args);
			} finally {
			}
		}

		static IntPtr id_setRotation_Landroid_view_View_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewHelper']/method[@name='setRotation' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='float']]"
		[Register ("setRotation", "(Landroid/view/View;F)V", "")]
		public static unsafe void SetRotation (global::Android.Views.View p0, float p1)
		{
			if (id_setRotation_Landroid_view_View_F == IntPtr.Zero)
				id_setRotation_Landroid_view_View_F = JNIEnv.GetStaticMethodID (class_ref, "setRotation", "(Landroid/view/View;F)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setRotation_Landroid_view_View_F, __args);
			} finally {
			}
		}

		static IntPtr id_setRotationX_Landroid_view_View_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewHelper']/method[@name='setRotationX' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='float']]"
		[Register ("setRotationX", "(Landroid/view/View;F)V", "")]
		public static unsafe void SetRotationX (global::Android.Views.View p0, float p1)
		{
			if (id_setRotationX_Landroid_view_View_F == IntPtr.Zero)
				id_setRotationX_Landroid_view_View_F = JNIEnv.GetStaticMethodID (class_ref, "setRotationX", "(Landroid/view/View;F)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setRotationX_Landroid_view_View_F, __args);
			} finally {
			}
		}

		static IntPtr id_setRotationY_Landroid_view_View_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewHelper']/method[@name='setRotationY' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='float']]"
		[Register ("setRotationY", "(Landroid/view/View;F)V", "")]
		public static unsafe void SetRotationY (global::Android.Views.View p0, float p1)
		{
			if (id_setRotationY_Landroid_view_View_F == IntPtr.Zero)
				id_setRotationY_Landroid_view_View_F = JNIEnv.GetStaticMethodID (class_ref, "setRotationY", "(Landroid/view/View;F)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setRotationY_Landroid_view_View_F, __args);
			} finally {
			}
		}

		static IntPtr id_setScaleX_Landroid_view_View_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewHelper']/method[@name='setScaleX' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='float']]"
		[Register ("setScaleX", "(Landroid/view/View;F)V", "")]
		public static unsafe void SetScaleX (global::Android.Views.View p0, float p1)
		{
			if (id_setScaleX_Landroid_view_View_F == IntPtr.Zero)
				id_setScaleX_Landroid_view_View_F = JNIEnv.GetStaticMethodID (class_ref, "setScaleX", "(Landroid/view/View;F)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setScaleX_Landroid_view_View_F, __args);
			} finally {
			}
		}

		static IntPtr id_setScaleY_Landroid_view_View_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewHelper']/method[@name='setScaleY' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='float']]"
		[Register ("setScaleY", "(Landroid/view/View;F)V", "")]
		public static unsafe void SetScaleY (global::Android.Views.View p0, float p1)
		{
			if (id_setScaleY_Landroid_view_View_F == IntPtr.Zero)
				id_setScaleY_Landroid_view_View_F = JNIEnv.GetStaticMethodID (class_ref, "setScaleY", "(Landroid/view/View;F)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setScaleY_Landroid_view_View_F, __args);
			} finally {
			}
		}

		static IntPtr id_setScrollX_Landroid_view_View_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewHelper']/method[@name='setScrollX' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("setScrollX", "(Landroid/view/View;I)V", "")]
		public static unsafe void SetScrollX (global::Android.Views.View p0, int p1)
		{
			if (id_setScrollX_Landroid_view_View_I == IntPtr.Zero)
				id_setScrollX_Landroid_view_View_I = JNIEnv.GetStaticMethodID (class_ref, "setScrollX", "(Landroid/view/View;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setScrollX_Landroid_view_View_I, __args);
			} finally {
			}
		}

		static IntPtr id_setScrollY_Landroid_view_View_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewHelper']/method[@name='setScrollY' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("setScrollY", "(Landroid/view/View;I)V", "")]
		public static unsafe void SetScrollY (global::Android.Views.View p0, int p1)
		{
			if (id_setScrollY_Landroid_view_View_I == IntPtr.Zero)
				id_setScrollY_Landroid_view_View_I = JNIEnv.GetStaticMethodID (class_ref, "setScrollY", "(Landroid/view/View;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setScrollY_Landroid_view_View_I, __args);
			} finally {
			}
		}

		static IntPtr id_setTranslationX_Landroid_view_View_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewHelper']/method[@name='setTranslationX' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='float']]"
		[Register ("setTranslationX", "(Landroid/view/View;F)V", "")]
		public static unsafe void SetTranslationX (global::Android.Views.View p0, float p1)
		{
			if (id_setTranslationX_Landroid_view_View_F == IntPtr.Zero)
				id_setTranslationX_Landroid_view_View_F = JNIEnv.GetStaticMethodID (class_ref, "setTranslationX", "(Landroid/view/View;F)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setTranslationX_Landroid_view_View_F, __args);
			} finally {
			}
		}

		static IntPtr id_setTranslationY_Landroid_view_View_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewHelper']/method[@name='setTranslationY' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='float']]"
		[Register ("setTranslationY", "(Landroid/view/View;F)V", "")]
		public static unsafe void SetTranslationY (global::Android.Views.View p0, float p1)
		{
			if (id_setTranslationY_Landroid_view_View_F == IntPtr.Zero)
				id_setTranslationY_Landroid_view_View_F = JNIEnv.GetStaticMethodID (class_ref, "setTranslationY", "(Landroid/view/View;F)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setTranslationY_Landroid_view_View_F, __args);
			} finally {
			}
		}

		static IntPtr id_setX_Landroid_view_View_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewHelper']/method[@name='setX' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='float']]"
		[Register ("setX", "(Landroid/view/View;F)V", "")]
		public static unsafe void SetX (global::Android.Views.View p0, float p1)
		{
			if (id_setX_Landroid_view_View_F == IntPtr.Zero)
				id_setX_Landroid_view_View_F = JNIEnv.GetStaticMethodID (class_ref, "setX", "(Landroid/view/View;F)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setX_Landroid_view_View_F, __args);
			} finally {
			}
		}

		static IntPtr id_setY_Landroid_view_View_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view']/class[@name='ViewHelper']/method[@name='setY' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='float']]"
		[Register ("setY", "(Landroid/view/View;F)V", "")]
		public static unsafe void SetY (global::Android.Views.View p0, float p1)
		{
			if (id_setY_Landroid_view_View_F == IntPtr.Zero)
				id_setY_Landroid_view_View_F = JNIEnv.GetStaticMethodID (class_ref, "setY", "(Landroid/view/View;F)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setY_Landroid_view_View_F, __args);
			} finally {
			}
		}

	}
}
