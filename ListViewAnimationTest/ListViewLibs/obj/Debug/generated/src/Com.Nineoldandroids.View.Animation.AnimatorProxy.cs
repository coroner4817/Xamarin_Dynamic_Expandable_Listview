using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nineoldandroids.View.Animation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nineoldandroids.view.animation']/class[@name='AnimatorProxy']"
	[global::Android.Runtime.Register ("com/nineoldandroids/view/animation/AnimatorProxy", DoNotGenerateAcw=true)]
	public sealed partial class AnimatorProxy : global::Android.Views.Animations.Animation {


		static IntPtr NEEDS_PROXY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.nineoldandroids.view.animation']/class[@name='AnimatorProxy']/field[@name='NEEDS_PROXY']"
		[Register ("NEEDS_PROXY")]
		public static bool NeedsProxy {
			get {
				if (NEEDS_PROXY_jfieldId == IntPtr.Zero)
					NEEDS_PROXY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NEEDS_PROXY", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, NEEDS_PROXY_jfieldId);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nineoldandroids/view/animation/AnimatorProxy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AnimatorProxy); }
		}

		internal AnimatorProxy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getAlpha;
		static IntPtr id_setAlpha_F;
		public unsafe float Alpha {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view.animation']/class[@name='AnimatorProxy']/method[@name='getAlpha' and count(parameter)=0]"
			[Register ("getAlpha", "()F", "GetGetAlphaHandler")]
			get {
				if (id_getAlpha == IntPtr.Zero)
					id_getAlpha = JNIEnv.GetMethodID (class_ref, "getAlpha", "()F");
				try {
					return JNIEnv.CallFloatMethod  (Handle, id_getAlpha);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view.animation']/class[@name='AnimatorProxy']/method[@name='setAlpha' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setAlpha", "(F)V", "GetSetAlpha_FHandler")]
			set {
				if (id_setAlpha_F == IntPtr.Zero)
					id_setAlpha_F = JNIEnv.GetMethodID (class_ref, "setAlpha", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setAlpha_F, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getPivotX;
		static IntPtr id_setPivotX_F;
		public unsafe float PivotX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view.animation']/class[@name='AnimatorProxy']/method[@name='getPivotX' and count(parameter)=0]"
			[Register ("getPivotX", "()F", "GetGetPivotXHandler")]
			get {
				if (id_getPivotX == IntPtr.Zero)
					id_getPivotX = JNIEnv.GetMethodID (class_ref, "getPivotX", "()F");
				try {
					return JNIEnv.CallFloatMethod  (Handle, id_getPivotX);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view.animation']/class[@name='AnimatorProxy']/method[@name='setPivotX' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setPivotX", "(F)V", "GetSetPivotX_FHandler")]
			set {
				if (id_setPivotX_F == IntPtr.Zero)
					id_setPivotX_F = JNIEnv.GetMethodID (class_ref, "setPivotX", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setPivotX_F, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getPivotY;
		static IntPtr id_setPivotY_F;
		public unsafe float PivotY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view.animation']/class[@name='AnimatorProxy']/method[@name='getPivotY' and count(parameter)=0]"
			[Register ("getPivotY", "()F", "GetGetPivotYHandler")]
			get {
				if (id_getPivotY == IntPtr.Zero)
					id_getPivotY = JNIEnv.GetMethodID (class_ref, "getPivotY", "()F");
				try {
					return JNIEnv.CallFloatMethod  (Handle, id_getPivotY);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view.animation']/class[@name='AnimatorProxy']/method[@name='setPivotY' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setPivotY", "(F)V", "GetSetPivotY_FHandler")]
			set {
				if (id_setPivotY_F == IntPtr.Zero)
					id_setPivotY_F = JNIEnv.GetMethodID (class_ref, "setPivotY", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setPivotY_F, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getRotation;
		static IntPtr id_setRotation_F;
		public unsafe float Rotation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view.animation']/class[@name='AnimatorProxy']/method[@name='getRotation' and count(parameter)=0]"
			[Register ("getRotation", "()F", "GetGetRotationHandler")]
			get {
				if (id_getRotation == IntPtr.Zero)
					id_getRotation = JNIEnv.GetMethodID (class_ref, "getRotation", "()F");
				try {
					return JNIEnv.CallFloatMethod  (Handle, id_getRotation);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view.animation']/class[@name='AnimatorProxy']/method[@name='setRotation' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setRotation", "(F)V", "GetSetRotation_FHandler")]
			set {
				if (id_setRotation_F == IntPtr.Zero)
					id_setRotation_F = JNIEnv.GetMethodID (class_ref, "setRotation", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setRotation_F, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getRotationX;
		static IntPtr id_setRotationX_F;
		public unsafe float RotationX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view.animation']/class[@name='AnimatorProxy']/method[@name='getRotationX' and count(parameter)=0]"
			[Register ("getRotationX", "()F", "GetGetRotationXHandler")]
			get {
				if (id_getRotationX == IntPtr.Zero)
					id_getRotationX = JNIEnv.GetMethodID (class_ref, "getRotationX", "()F");
				try {
					return JNIEnv.CallFloatMethod  (Handle, id_getRotationX);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view.animation']/class[@name='AnimatorProxy']/method[@name='setRotationX' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setRotationX", "(F)V", "GetSetRotationX_FHandler")]
			set {
				if (id_setRotationX_F == IntPtr.Zero)
					id_setRotationX_F = JNIEnv.GetMethodID (class_ref, "setRotationX", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setRotationX_F, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getRotationY;
		static IntPtr id_setRotationY_F;
		public unsafe float RotationY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view.animation']/class[@name='AnimatorProxy']/method[@name='getRotationY' and count(parameter)=0]"
			[Register ("getRotationY", "()F", "GetGetRotationYHandler")]
			get {
				if (id_getRotationY == IntPtr.Zero)
					id_getRotationY = JNIEnv.GetMethodID (class_ref, "getRotationY", "()F");
				try {
					return JNIEnv.CallFloatMethod  (Handle, id_getRotationY);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view.animation']/class[@name='AnimatorProxy']/method[@name='setRotationY' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setRotationY", "(F)V", "GetSetRotationY_FHandler")]
			set {
				if (id_setRotationY_F == IntPtr.Zero)
					id_setRotationY_F = JNIEnv.GetMethodID (class_ref, "setRotationY", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setRotationY_F, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getScaleX;
		static IntPtr id_setScaleX_F;
		public unsafe float ScaleX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view.animation']/class[@name='AnimatorProxy']/method[@name='getScaleX' and count(parameter)=0]"
			[Register ("getScaleX", "()F", "GetGetScaleXHandler")]
			get {
				if (id_getScaleX == IntPtr.Zero)
					id_getScaleX = JNIEnv.GetMethodID (class_ref, "getScaleX", "()F");
				try {
					return JNIEnv.CallFloatMethod  (Handle, id_getScaleX);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view.animation']/class[@name='AnimatorProxy']/method[@name='setScaleX' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setScaleX", "(F)V", "GetSetScaleX_FHandler")]
			set {
				if (id_setScaleX_F == IntPtr.Zero)
					id_setScaleX_F = JNIEnv.GetMethodID (class_ref, "setScaleX", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setScaleX_F, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getScaleY;
		static IntPtr id_setScaleY_F;
		public unsafe float ScaleY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view.animation']/class[@name='AnimatorProxy']/method[@name='getScaleY' and count(parameter)=0]"
			[Register ("getScaleY", "()F", "GetGetScaleYHandler")]
			get {
				if (id_getScaleY == IntPtr.Zero)
					id_getScaleY = JNIEnv.GetMethodID (class_ref, "getScaleY", "()F");
				try {
					return JNIEnv.CallFloatMethod  (Handle, id_getScaleY);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view.animation']/class[@name='AnimatorProxy']/method[@name='setScaleY' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setScaleY", "(F)V", "GetSetScaleY_FHandler")]
			set {
				if (id_setScaleY_F == IntPtr.Zero)
					id_setScaleY_F = JNIEnv.GetMethodID (class_ref, "setScaleY", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setScaleY_F, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getScrollX;
		static IntPtr id_setScrollX_I;
		public unsafe int ScrollX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view.animation']/class[@name='AnimatorProxy']/method[@name='getScrollX' and count(parameter)=0]"
			[Register ("getScrollX", "()I", "GetGetScrollXHandler")]
			get {
				if (id_getScrollX == IntPtr.Zero)
					id_getScrollX = JNIEnv.GetMethodID (class_ref, "getScrollX", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getScrollX);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view.animation']/class[@name='AnimatorProxy']/method[@name='setScrollX' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setScrollX", "(I)V", "GetSetScrollX_IHandler")]
			set {
				if (id_setScrollX_I == IntPtr.Zero)
					id_setScrollX_I = JNIEnv.GetMethodID (class_ref, "setScrollX", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setScrollX_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getScrollY;
		static IntPtr id_setScrollY_I;
		public unsafe int ScrollY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view.animation']/class[@name='AnimatorProxy']/method[@name='getScrollY' and count(parameter)=0]"
			[Register ("getScrollY", "()I", "GetGetScrollYHandler")]
			get {
				if (id_getScrollY == IntPtr.Zero)
					id_getScrollY = JNIEnv.GetMethodID (class_ref, "getScrollY", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getScrollY);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view.animation']/class[@name='AnimatorProxy']/method[@name='setScrollY' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setScrollY", "(I)V", "GetSetScrollY_IHandler")]
			set {
				if (id_setScrollY_I == IntPtr.Zero)
					id_setScrollY_I = JNIEnv.GetMethodID (class_ref, "setScrollY", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setScrollY_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getTranslationX;
		static IntPtr id_setTranslationX_F;
		public unsafe float TranslationX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view.animation']/class[@name='AnimatorProxy']/method[@name='getTranslationX' and count(parameter)=0]"
			[Register ("getTranslationX", "()F", "GetGetTranslationXHandler")]
			get {
				if (id_getTranslationX == IntPtr.Zero)
					id_getTranslationX = JNIEnv.GetMethodID (class_ref, "getTranslationX", "()F");
				try {
					return JNIEnv.CallFloatMethod  (Handle, id_getTranslationX);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view.animation']/class[@name='AnimatorProxy']/method[@name='setTranslationX' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setTranslationX", "(F)V", "GetSetTranslationX_FHandler")]
			set {
				if (id_setTranslationX_F == IntPtr.Zero)
					id_setTranslationX_F = JNIEnv.GetMethodID (class_ref, "setTranslationX", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setTranslationX_F, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getTranslationY;
		static IntPtr id_setTranslationY_F;
		public unsafe float TranslationY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view.animation']/class[@name='AnimatorProxy']/method[@name='getTranslationY' and count(parameter)=0]"
			[Register ("getTranslationY", "()F", "GetGetTranslationYHandler")]
			get {
				if (id_getTranslationY == IntPtr.Zero)
					id_getTranslationY = JNIEnv.GetMethodID (class_ref, "getTranslationY", "()F");
				try {
					return JNIEnv.CallFloatMethod  (Handle, id_getTranslationY);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view.animation']/class[@name='AnimatorProxy']/method[@name='setTranslationY' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setTranslationY", "(F)V", "GetSetTranslationY_FHandler")]
			set {
				if (id_setTranslationY_F == IntPtr.Zero)
					id_setTranslationY_F = JNIEnv.GetMethodID (class_ref, "setTranslationY", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod  (Handle, id_setTranslationY_F, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getX;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view.animation']/class[@name='AnimatorProxy']/method[@name='getX' and count(parameter)=0]"
		[Register ("getX", "()F", "")]
		public unsafe float GetX ()
		{
			if (id_getX == IntPtr.Zero)
				id_getX = JNIEnv.GetMethodID (class_ref, "getX", "()F");
			try {
				return JNIEnv.CallFloatMethod  (Handle, id_getX);
			} finally {
			}
		}

		static IntPtr id_getY;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view.animation']/class[@name='AnimatorProxy']/method[@name='getY' and count(parameter)=0]"
		[Register ("getY", "()F", "")]
		public unsafe float GetY ()
		{
			if (id_getY == IntPtr.Zero)
				id_getY = JNIEnv.GetMethodID (class_ref, "getY", "()F");
			try {
				return JNIEnv.CallFloatMethod  (Handle, id_getY);
			} finally {
			}
		}

		static IntPtr id_setX_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view.animation']/class[@name='AnimatorProxy']/method[@name='setX' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setX", "(F)V", "")]
		public unsafe void SetX (float p0)
		{
			if (id_setX_F == IntPtr.Zero)
				id_setX_F = JNIEnv.GetMethodID (class_ref, "setX", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_setX_F, __args);
			} finally {
			}
		}

		static IntPtr id_setY_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view.animation']/class[@name='AnimatorProxy']/method[@name='setY' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setY", "(F)V", "")]
		public unsafe void SetY (float p0)
		{
			if (id_setY_F == IntPtr.Zero)
				id_setY_F = JNIEnv.GetMethodID (class_ref, "setY", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_setY_F, __args);
			} finally {
			}
		}

		static IntPtr id_wrap_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nineoldandroids.view.animation']/class[@name='AnimatorProxy']/method[@name='wrap' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("wrap", "(Landroid/view/View;)Lcom/nineoldandroids/view/animation/AnimatorProxy;", "")]
		public static unsafe global::Com.Nineoldandroids.View.Animation.AnimatorProxy Wrap (global::Android.Views.View p0)
		{
			if (id_wrap_Landroid_view_View_ == IntPtr.Zero)
				id_wrap_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "wrap", "(Landroid/view/View;)Lcom/nineoldandroids/view/animation/AnimatorProxy;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Nineoldandroids.View.Animation.AnimatorProxy __ret = global::Java.Lang.Object.GetObject<global::Com.Nineoldandroids.View.Animation.AnimatorProxy> (JNIEnv.CallStaticObjectMethod  (class_ref, id_wrap_Landroid_view_View_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
