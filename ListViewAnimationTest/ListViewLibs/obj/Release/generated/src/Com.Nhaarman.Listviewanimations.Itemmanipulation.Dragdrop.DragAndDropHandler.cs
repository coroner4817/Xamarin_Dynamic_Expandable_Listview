using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='DragAndDropHandler']"
	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/dragdrop/DragAndDropHandler", DoNotGenerateAcw=true)]
	public partial class DragAndDropHandler : global::Java.Lang.Object, global::Com.Nhaarman.Listviewanimations.Itemmanipulation.ITouchEventHandler {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='DragAndDropHandler.DefaultDraggableManager']"
		[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/dragdrop/DragAndDropHandler$DefaultDraggableManager", DoNotGenerateAcw=true)]
		public partial class DefaultDraggableManager : global::Java.Lang.Object, global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IDraggableManager {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/dragdrop/DragAndDropHandler$DefaultDraggableManager", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DefaultDraggableManager); }
			}

			protected DefaultDraggableManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_isDraggable_Landroid_view_View_IFF;
#pragma warning disable 0169
			static Delegate GetIsDraggable_Landroid_view_View_IFFHandler ()
			{
				if (cb_isDraggable_Landroid_view_View_IFF == null)
					cb_isDraggable_Landroid_view_View_IFF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, float, float, bool>) n_IsDraggable_Landroid_view_View_IFF);
				return cb_isDraggable_Landroid_view_View_IFF;
			}

			static bool n_IsDraggable_Landroid_view_View_IFF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, float p2, float p3)
			{
				global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DragAndDropHandler.DefaultDraggableManager __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DragAndDropHandler.DefaultDraggableManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.IsDraggable (p0, p1, p2, p3);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_isDraggable_Landroid_view_View_IFF;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='DragAndDropHandler.DefaultDraggableManager']/method[@name='isDraggable' and count(parameter)=4 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
			[Register ("isDraggable", "(Landroid/view/View;IFF)Z", "GetIsDraggable_Landroid_view_View_IFFHandler")]
			public virtual unsafe bool IsDraggable (global::Android.Views.View p0, int p1, float p2, float p3)
			{
				if (id_isDraggable_Landroid_view_View_IFF == IntPtr.Zero)
					id_isDraggable_Landroid_view_View_IFF = JNIEnv.GetMethodID (class_ref, "isDraggable", "(Landroid/view/View;IFF)Z");
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);

					bool __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallBooleanMethod  (Handle, id_isDraggable_Landroid_view_View_IFF, __args);
					else
						__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDraggable", "(Landroid/view/View;IFF)Z"), __args);
					return __ret;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='DragAndDropHandler.KitKatSwitchViewAnimator']"
		[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/dragdrop/DragAndDropHandler$KitKatSwitchViewAnimator", DoNotGenerateAcw=true)]
		public partial class KitKatSwitchViewAnimator : global::Java.Lang.Object, global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DragAndDropHandler.ISwitchViewAnimator {

			// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='DragAndDropHandler.KitKatSwitchViewAnimator.AnimateSwitchViewOnPreDrawListener']"
			[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/dragdrop/DragAndDropHandler$KitKatSwitchViewAnimator$AnimateSwitchViewOnPreDrawListener", DoNotGenerateAcw=true)]
			public partial class AnimateSwitchViewOnPreDrawListener : global::Java.Lang.Object, global::Android.Views.ViewTreeObserver.IOnPreDrawListener {

				internal static IntPtr java_class_handle;
				internal static IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/dragdrop/DragAndDropHandler$KitKatSwitchViewAnimator$AnimateSwitchViewOnPreDrawListener", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (AnimateSwitchViewOnPreDrawListener); }
				}

				protected AnimateSwitchViewOnPreDrawListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static Delegate cb_onPreDraw;
#pragma warning disable 0169
				static Delegate GetOnPreDrawHandler ()
				{
					if (cb_onPreDraw == null)
						cb_onPreDraw = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_OnPreDraw);
					return cb_onPreDraw;
				}

				static bool n_OnPreDraw (IntPtr jnienv, IntPtr native__this)
				{
					global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DragAndDropHandler.KitKatSwitchViewAnimator.AnimateSwitchViewOnPreDrawListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DragAndDropHandler.KitKatSwitchViewAnimator.AnimateSwitchViewOnPreDrawListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					return __this.OnPreDraw ();
				}
#pragma warning restore 0169

				static IntPtr id_onPreDraw;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='DragAndDropHandler.KitKatSwitchViewAnimator.AnimateSwitchViewOnPreDrawListener']/method[@name='onPreDraw' and count(parameter)=0]"
				[Register ("onPreDraw", "()Z", "GetOnPreDrawHandler")]
				public virtual unsafe bool OnPreDraw ()
				{
					if (id_onPreDraw == IntPtr.Zero)
						id_onPreDraw = JNIEnv.GetMethodID (class_ref, "onPreDraw", "()Z");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod  (Handle, id_onPreDraw);
						else
							return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPreDraw", "()Z"));
					} finally {
					}
				}

			}

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/dragdrop/DragAndDropHandler$KitKatSwitchViewAnimator", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (KitKatSwitchViewAnimator); }
			}

			protected KitKatSwitchViewAnimator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_animateSwitchView_JF;
#pragma warning disable 0169
			static Delegate GetAnimateSwitchView_JFHandler ()
			{
				if (cb_animateSwitchView_JF == null)
					cb_animateSwitchView_JF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, float>) n_AnimateSwitchView_JF);
				return cb_animateSwitchView_JF;
			}

			static void n_AnimateSwitchView_JF (IntPtr jnienv, IntPtr native__this, long p0, float p1)
			{
				global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DragAndDropHandler.KitKatSwitchViewAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DragAndDropHandler.KitKatSwitchViewAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.AnimateSwitchView (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_animateSwitchView_JF;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='DragAndDropHandler.KitKatSwitchViewAnimator']/method[@name='animateSwitchView' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='float']]"
			[Register ("animateSwitchView", "(JF)V", "GetAnimateSwitchView_JFHandler")]
			public virtual unsafe void AnimateSwitchView (long p0, float p1)
			{
				if (id_animateSwitchView_JF == IntPtr.Zero)
					id_animateSwitchView_JF = JNIEnv.GetMethodID (class_ref, "animateSwitchView", "(JF)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_animateSwitchView_JF, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "animateSwitchView", "(JF)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='DragAndDropHandler.LSwitchViewAnimator']"
		[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/dragdrop/DragAndDropHandler$LSwitchViewAnimator", DoNotGenerateAcw=true)]
		public partial class LSwitchViewAnimator : global::Java.Lang.Object, global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DragAndDropHandler.ISwitchViewAnimator {

			// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='DragAndDropHandler.LSwitchViewAnimator.AnimateSwitchViewOnPreDrawListener']"
			[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/dragdrop/DragAndDropHandler$LSwitchViewAnimator$AnimateSwitchViewOnPreDrawListener", DoNotGenerateAcw=true)]
			public partial class AnimateSwitchViewOnPreDrawListener : global::Java.Lang.Object, global::Android.Views.ViewTreeObserver.IOnPreDrawListener {

				internal static IntPtr java_class_handle;
				internal static IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/dragdrop/DragAndDropHandler$LSwitchViewAnimator$AnimateSwitchViewOnPreDrawListener", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (AnimateSwitchViewOnPreDrawListener); }
				}

				protected AnimateSwitchViewOnPreDrawListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static Delegate cb_onPreDraw;
#pragma warning disable 0169
				static Delegate GetOnPreDrawHandler ()
				{
					if (cb_onPreDraw == null)
						cb_onPreDraw = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_OnPreDraw);
					return cb_onPreDraw;
				}

				static bool n_OnPreDraw (IntPtr jnienv, IntPtr native__this)
				{
					global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DragAndDropHandler.LSwitchViewAnimator.AnimateSwitchViewOnPreDrawListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DragAndDropHandler.LSwitchViewAnimator.AnimateSwitchViewOnPreDrawListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					return __this.OnPreDraw ();
				}
#pragma warning restore 0169

				static IntPtr id_onPreDraw;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='DragAndDropHandler.LSwitchViewAnimator.AnimateSwitchViewOnPreDrawListener']/method[@name='onPreDraw' and count(parameter)=0]"
				[Register ("onPreDraw", "()Z", "GetOnPreDrawHandler")]
				public virtual unsafe bool OnPreDraw ()
				{
					if (id_onPreDraw == IntPtr.Zero)
						id_onPreDraw = JNIEnv.GetMethodID (class_ref, "onPreDraw", "()Z");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod  (Handle, id_onPreDraw);
						else
							return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPreDraw", "()Z"));
					} finally {
					}
				}

			}

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/dragdrop/DragAndDropHandler$LSwitchViewAnimator", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LSwitchViewAnimator); }
			}

			protected LSwitchViewAnimator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_animateSwitchView_JF;
#pragma warning disable 0169
			static Delegate GetAnimateSwitchView_JFHandler ()
			{
				if (cb_animateSwitchView_JF == null)
					cb_animateSwitchView_JF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, float>) n_AnimateSwitchView_JF);
				return cb_animateSwitchView_JF;
			}

			static void n_AnimateSwitchView_JF (IntPtr jnienv, IntPtr native__this, long p0, float p1)
			{
				global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DragAndDropHandler.LSwitchViewAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DragAndDropHandler.LSwitchViewAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.AnimateSwitchView (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_animateSwitchView_JF;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='DragAndDropHandler.LSwitchViewAnimator']/method[@name='animateSwitchView' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='float']]"
			[Register ("animateSwitchView", "(JF)V", "GetAnimateSwitchView_JFHandler")]
			public virtual unsafe void AnimateSwitchView (long p0, float p1)
			{
				if (id_animateSwitchView_JF == IntPtr.Zero)
					id_animateSwitchView_JF = JNIEnv.GetMethodID (class_ref, "animateSwitchView", "(JF)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_animateSwitchView_JF, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "animateSwitchView", "(JF)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='DragAndDropHandler.ScrollHandler']"
		[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/dragdrop/DragAndDropHandler$ScrollHandler", DoNotGenerateAcw=true)]
		public partial class ScrollHandler : global::Java.Lang.Object, global::Android.Widget.AbsListView.IOnScrollListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/dragdrop/DragAndDropHandler$ScrollHandler", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ScrollHandler); }
			}

			protected ScrollHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onScroll_Landroid_widget_AbsListView_III;
#pragma warning disable 0169
			static Delegate GetOnScroll_Landroid_widget_AbsListView_IIIHandler ()
			{
				if (cb_onScroll_Landroid_widget_AbsListView_III == null)
					cb_onScroll_Landroid_widget_AbsListView_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int>) n_OnScroll_Landroid_widget_AbsListView_III);
				return cb_onScroll_Landroid_widget_AbsListView_III;
			}

			static void n_OnScroll_Landroid_widget_AbsListView_III (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3)
			{
				global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DragAndDropHandler.ScrollHandler __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DragAndDropHandler.ScrollHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Widget.AbsListView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.AbsListView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnScroll (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			static IntPtr id_onScroll_Landroid_widget_AbsListView_III;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='DragAndDropHandler.ScrollHandler']/method[@name='onScroll' and count(parameter)=4 and parameter[1][@type='android.widget.AbsListView'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register ("onScroll", "(Landroid/widget/AbsListView;III)V", "GetOnScroll_Landroid_widget_AbsListView_IIIHandler")]
			public virtual unsafe void OnScroll (global::Android.Widget.AbsListView p0, int p1, int p2, int p3)
			{
				if (id_onScroll_Landroid_widget_AbsListView_III == IntPtr.Zero)
					id_onScroll_Landroid_widget_AbsListView_III = JNIEnv.GetMethodID (class_ref, "onScroll", "(Landroid/widget/AbsListView;III)V");
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onScroll_Landroid_widget_AbsListView_III, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onScroll", "(Landroid/widget/AbsListView;III)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onScrollStateChanged_Landroid_widget_AbsListView_I;
#pragma warning disable 0169
			static Delegate GetOnScrollStateChanged_Landroid_widget_AbsListView_IHandler ()
			{
				if (cb_onScrollStateChanged_Landroid_widget_AbsListView_I == null)
					cb_onScrollStateChanged_Landroid_widget_AbsListView_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnScrollStateChanged_Landroid_widget_AbsListView_I);
				return cb_onScrollStateChanged_Landroid_widget_AbsListView_I;
			}

			static void n_OnScrollStateChanged_Landroid_widget_AbsListView_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
			{
				global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DragAndDropHandler.ScrollHandler __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DragAndDropHandler.ScrollHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Widget.AbsListView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.AbsListView> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Widget.ScrollState p1 = (global::Android.Widget.ScrollState) native_p1;
				__this.OnScrollStateChanged (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onScrollStateChanged_Landroid_widget_AbsListView_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='DragAndDropHandler.ScrollHandler']/method[@name='onScrollStateChanged' and count(parameter)=2 and parameter[1][@type='android.widget.AbsListView'] and parameter[2][@type='int']]"
			[Register ("onScrollStateChanged", "(Landroid/widget/AbsListView;I)V", "GetOnScrollStateChanged_Landroid_widget_AbsListView_IHandler")]
			public virtual unsafe void OnScrollStateChanged (global::Android.Widget.AbsListView p0, [global::Android.Runtime.GeneratedEnum] global::Android.Widget.ScrollState p1)
			{
				if (id_onScrollStateChanged_Landroid_widget_AbsListView_I == IntPtr.Zero)
					id_onScrollStateChanged_Landroid_widget_AbsListView_I = JNIEnv.GetMethodID (class_ref, "onScrollStateChanged", "(Landroid/widget/AbsListView;I)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue ((int) p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onScrollStateChanged_Landroid_widget_AbsListView_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onScrollStateChanged", "(Landroid/widget/AbsListView;I)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='DragAndDropHandler.SettleHoverDrawableAnimatorListener']"
		[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/dragdrop/DragAndDropHandler$SettleHoverDrawableAnimatorListener", DoNotGenerateAcw=true)]
		public partial class SettleHoverDrawableAnimatorListener : global::Android.Animation.AnimatorListenerAdapter, global::Android.Animation.ValueAnimator.IAnimatorUpdateListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/dragdrop/DragAndDropHandler$SettleHoverDrawableAnimatorListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SettleHoverDrawableAnimatorListener); }
			}

			protected SettleHoverDrawableAnimatorListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onAnimationUpdate_Landroid_animation_ValueAnimator_;
#pragma warning disable 0169
			static Delegate GetOnAnimationUpdate_Landroid_animation_ValueAnimator_Handler ()
			{
				if (cb_onAnimationUpdate_Landroid_animation_ValueAnimator_ == null)
					cb_onAnimationUpdate_Landroid_animation_ValueAnimator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAnimationUpdate_Landroid_animation_ValueAnimator_);
				return cb_onAnimationUpdate_Landroid_animation_ValueAnimator_;
			}

			static void n_OnAnimationUpdate_Landroid_animation_ValueAnimator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DragAndDropHandler.SettleHoverDrawableAnimatorListener __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DragAndDropHandler.SettleHoverDrawableAnimatorListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Animation.ValueAnimator p0 = global::Java.Lang.Object.GetObject<global::Android.Animation.ValueAnimator> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnAnimationUpdate (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onAnimationUpdate_Landroid_animation_ValueAnimator_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='DragAndDropHandler.SettleHoverDrawableAnimatorListener']/method[@name='onAnimationUpdate' and count(parameter)=1 and parameter[1][@type='android.animation.ValueAnimator']]"
			[Register ("onAnimationUpdate", "(Landroid/animation/ValueAnimator;)V", "GetOnAnimationUpdate_Landroid_animation_ValueAnimator_Handler")]
			public virtual unsafe void OnAnimationUpdate (global::Android.Animation.ValueAnimator p0)
			{
				if (id_onAnimationUpdate_Landroid_animation_ValueAnimator_ == IntPtr.Zero)
					id_onAnimationUpdate_Landroid_animation_ValueAnimator_ = JNIEnv.GetMethodID (class_ref, "onAnimationUpdate", "(Landroid/animation/ValueAnimator;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_onAnimationUpdate_Landroid_animation_ValueAnimator_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAnimationUpdate", "(Landroid/animation/ValueAnimator;)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/interface[@name='DragAndDropHandler.SwitchViewAnimator']"
		[Register ("com/nhaarman/listviewanimations/itemmanipulation/dragdrop/DragAndDropHandler$SwitchViewAnimator", "", "Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DragAndDropHandler/ISwitchViewAnimatorInvoker")]
		public partial interface ISwitchViewAnimator : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/interface[@name='DragAndDropHandler.SwitchViewAnimator']/method[@name='animateSwitchView' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='float']]"
			[Register ("animateSwitchView", "(JF)V", "GetAnimateSwitchView_JFHandler:Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DragAndDropHandler/ISwitchViewAnimatorInvoker, ListViewLibs")]
			void AnimateSwitchView (long p0, float p1);

		}

		[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/dragdrop/DragAndDropHandler$SwitchViewAnimator", DoNotGenerateAcw=true)]
		internal class ISwitchViewAnimatorInvoker : global::Java.Lang.Object, ISwitchViewAnimator {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/dragdrop/DragAndDropHandler$SwitchViewAnimator");
			IntPtr class_ref;

			public static ISwitchViewAnimator GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ISwitchViewAnimator> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.nhaarman.listviewanimations.itemmanipulation.dragdrop.DragAndDropHandler.SwitchViewAnimator"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ISwitchViewAnimatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ISwitchViewAnimatorInvoker); }
			}

			static Delegate cb_animateSwitchView_JF;
#pragma warning disable 0169
			static Delegate GetAnimateSwitchView_JFHandler ()
			{
				if (cb_animateSwitchView_JF == null)
					cb_animateSwitchView_JF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, float>) n_AnimateSwitchView_JF);
				return cb_animateSwitchView_JF;
			}

			static void n_AnimateSwitchView_JF (IntPtr jnienv, IntPtr native__this, long p0, float p1)
			{
				global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DragAndDropHandler.ISwitchViewAnimator __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DragAndDropHandler.ISwitchViewAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.AnimateSwitchView (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_animateSwitchView_JF;
			public unsafe void AnimateSwitchView (long p0, float p1)
			{
				if (id_animateSwitchView_JF == IntPtr.Zero)
					id_animateSwitchView_JF = JNIEnv.GetMethodID (class_ref, "animateSwitchView", "(JF)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (Handle, id_animateSwitchView_JF, __args);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/dragdrop/DragAndDropHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DragAndDropHandler); }
		}

		protected DragAndDropHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_nhaarman_listviewanimations_itemmanipulation_DynamicListView_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='DragAndDropHandler']/constructor[@name='DragAndDropHandler' and count(parameter)=1 and parameter[1][@type='com.nhaarman.listviewanimations.itemmanipulation.DynamicListView']]"
		[Register (".ctor", "(Lcom/nhaarman/listviewanimations/itemmanipulation/DynamicListView;)V", "")]
		public unsafe DragAndDropHandler (global::Com.Nhaarman.Listviewanimations.Itemmanipulation.DynamicListView p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (DragAndDropHandler)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/nhaarman/listviewanimations/itemmanipulation/DynamicListView;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/nhaarman/listviewanimations/itemmanipulation/DynamicListView;)V", __args);
					return;
				}

				if (id_ctor_Lcom_nhaarman_listviewanimations_itemmanipulation_DynamicListView_ == IntPtr.Zero)
					id_ctor_Lcom_nhaarman_listviewanimations_itemmanipulation_DynamicListView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/nhaarman/listviewanimations/itemmanipulation/DynamicListView;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_nhaarman_listviewanimations_itemmanipulation_DynamicListView_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_nhaarman_listviewanimations_itemmanipulation_DynamicListView_, __args);
			} finally {
			}
		}

		static Delegate cb_isInteracting;
#pragma warning disable 0169
		static Delegate GetIsInteractingHandler ()
		{
			if (cb_isInteracting == null)
				cb_isInteracting = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInteracting);
			return cb_isInteracting;
		}

		static bool n_IsInteracting (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DragAndDropHandler __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DragAndDropHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInteracting;
		}
#pragma warning restore 0169

		static IntPtr id_isInteracting;
		public virtual unsafe bool IsInteracting {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='DragAndDropHandler']/method[@name='isInteracting' and count(parameter)=0]"
			[Register ("isInteracting", "()Z", "GetIsInteractingHandler")]
			get {
				if (id_isInteracting == IntPtr.Zero)
					id_isInteracting = JNIEnv.GetMethodID (class_ref, "isInteracting", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isInteracting);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isInteracting", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_dispatchDraw_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetDispatchDraw_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_dispatchDraw_Landroid_graphics_Canvas_ == null)
				cb_dispatchDraw_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DispatchDraw_Landroid_graphics_Canvas_);
			return cb_dispatchDraw_Landroid_graphics_Canvas_;
		}

		static void n_DispatchDraw_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DragAndDropHandler __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DragAndDropHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DispatchDraw (p0);
		}
#pragma warning restore 0169

		static IntPtr id_dispatchDraw_Landroid_graphics_Canvas_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='DragAndDropHandler']/method[@name='dispatchDraw' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("dispatchDraw", "(Landroid/graphics/Canvas;)V", "GetDispatchDraw_Landroid_graphics_Canvas_Handler")]
		public virtual unsafe void DispatchDraw (global::Android.Graphics.Canvas p0)
		{
			if (id_dispatchDraw_Landroid_graphics_Canvas_ == IntPtr.Zero)
				id_dispatchDraw_Landroid_graphics_Canvas_ = JNIEnv.GetMethodID (class_ref, "dispatchDraw", "(Landroid/graphics/Canvas;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_dispatchDraw_Landroid_graphics_Canvas_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onTouchEvent_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnTouchEvent_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onTouchEvent_Landroid_view_MotionEvent_ == null)
				cb_onTouchEvent_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnTouchEvent_Landroid_view_MotionEvent_);
			return cb_onTouchEvent_Landroid_view_MotionEvent_;
		}

		static bool n_OnTouchEvent_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DragAndDropHandler __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DragAndDropHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTouchEvent (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTouchEvent_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='DragAndDropHandler']/method[@name='onTouchEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("onTouchEvent", "(Landroid/view/MotionEvent;)Z", "GetOnTouchEvent_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe bool OnTouchEvent (global::Android.Views.MotionEvent p0)
		{
			if (id_onTouchEvent_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_onTouchEvent_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_onTouchEvent_Landroid_view_MotionEvent_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setAdapter_Landroid_widget_ListAdapter_;
#pragma warning disable 0169
		static Delegate GetSetAdapter_Landroid_widget_ListAdapter_Handler ()
		{
			if (cb_setAdapter_Landroid_widget_ListAdapter_ == null)
				cb_setAdapter_Landroid_widget_ListAdapter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAdapter_Landroid_widget_ListAdapter_);
			return cb_setAdapter_Landroid_widget_ListAdapter_;
		}

		static void n_SetAdapter_Landroid_widget_ListAdapter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DragAndDropHandler __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DragAndDropHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.IListAdapter p0 = (global::Android.Widget.IListAdapter)global::Java.Lang.Object.GetObject<global::Android.Widget.IListAdapter> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAdapter (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAdapter_Landroid_widget_ListAdapter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='DragAndDropHandler']/method[@name='setAdapter' and count(parameter)=1 and parameter[1][@type='android.widget.ListAdapter']]"
		[Register ("setAdapter", "(Landroid/widget/ListAdapter;)V", "GetSetAdapter_Landroid_widget_ListAdapter_Handler")]
		public virtual unsafe void SetAdapter (global::Android.Widget.IListAdapter p0)
		{
			if (id_setAdapter_Landroid_widget_ListAdapter_ == IntPtr.Zero)
				id_setAdapter_Landroid_widget_ListAdapter_ = JNIEnv.GetMethodID (class_ref, "setAdapter", "(Landroid/widget/ListAdapter;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAdapter_Landroid_widget_ListAdapter_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAdapter", "(Landroid/widget/ListAdapter;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDraggableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_DraggableManager_;
#pragma warning disable 0169
		static Delegate GetSetDraggableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_DraggableManager_Handler ()
		{
			if (cb_setDraggableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_DraggableManager_ == null)
				cb_setDraggableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_DraggableManager_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDraggableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_DraggableManager_);
			return cb_setDraggableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_DraggableManager_;
		}

		static void n_SetDraggableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_DraggableManager_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DragAndDropHandler __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DragAndDropHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IDraggableManager p0 = (global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IDraggableManager)global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IDraggableManager> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDraggableManager (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDraggableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_DraggableManager_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='DragAndDropHandler']/method[@name='setDraggableManager' and count(parameter)=1 and parameter[1][@type='com.nhaarman.listviewanimations.itemmanipulation.dragdrop.DraggableManager']]"
		[Register ("setDraggableManager", "(Lcom/nhaarman/listviewanimations/itemmanipulation/dragdrop/DraggableManager;)V", "GetSetDraggableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_DraggableManager_Handler")]
		public virtual unsafe void SetDraggableManager (global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IDraggableManager p0)
		{
			if (id_setDraggableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_DraggableManager_ == IntPtr.Zero)
				id_setDraggableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_DraggableManager_ = JNIEnv.GetMethodID (class_ref, "setDraggableManager", "(Lcom/nhaarman/listviewanimations/itemmanipulation/dragdrop/DraggableManager;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDraggableManager_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_DraggableManager_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDraggableManager", "(Lcom/nhaarman/listviewanimations/itemmanipulation/dragdrop/DraggableManager;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnItemMovedListener_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_OnItemMovedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnItemMovedListener_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_OnItemMovedListener_Handler ()
		{
			if (cb_setOnItemMovedListener_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_OnItemMovedListener_ == null)
				cb_setOnItemMovedListener_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_OnItemMovedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnItemMovedListener_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_OnItemMovedListener_);
			return cb_setOnItemMovedListener_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_OnItemMovedListener_;
		}

		static void n_SetOnItemMovedListener_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_OnItemMovedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DragAndDropHandler __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DragAndDropHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IOnItemMovedListener p0 = (global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IOnItemMovedListener)global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IOnItemMovedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnItemMovedListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnItemMovedListener_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_OnItemMovedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='DragAndDropHandler']/method[@name='setOnItemMovedListener' and count(parameter)=1 and parameter[1][@type='com.nhaarman.listviewanimations.itemmanipulation.dragdrop.OnItemMovedListener']]"
		[Register ("setOnItemMovedListener", "(Lcom/nhaarman/listviewanimations/itemmanipulation/dragdrop/OnItemMovedListener;)V", "GetSetOnItemMovedListener_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_OnItemMovedListener_Handler")]
		public virtual unsafe void SetOnItemMovedListener (global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IOnItemMovedListener p0)
		{
			if (id_setOnItemMovedListener_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_OnItemMovedListener_ == IntPtr.Zero)
				id_setOnItemMovedListener_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_OnItemMovedListener_ = JNIEnv.GetMethodID (class_ref, "setOnItemMovedListener", "(Lcom/nhaarman/listviewanimations/itemmanipulation/dragdrop/OnItemMovedListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOnItemMovedListener_Lcom_nhaarman_listviewanimations_itemmanipulation_dragdrop_OnItemMovedListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnItemMovedListener", "(Lcom/nhaarman/listviewanimations/itemmanipulation/dragdrop/OnItemMovedListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setScrollSpeed_F;
#pragma warning disable 0169
		static Delegate GetSetScrollSpeed_FHandler ()
		{
			if (cb_setScrollSpeed_F == null)
				cb_setScrollSpeed_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetScrollSpeed_F);
			return cb_setScrollSpeed_F;
		}

		static void n_SetScrollSpeed_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DragAndDropHandler __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DragAndDropHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScrollSpeed (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setScrollSpeed_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='DragAndDropHandler']/method[@name='setScrollSpeed' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setScrollSpeed", "(F)V", "GetSetScrollSpeed_FHandler")]
		public virtual unsafe void SetScrollSpeed (float p0)
		{
			if (id_setScrollSpeed_F == IntPtr.Zero)
				id_setScrollSpeed_F = JNIEnv.GetMethodID (class_ref, "setScrollSpeed", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setScrollSpeed_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScrollSpeed", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_startDragging_I;
#pragma warning disable 0169
		static Delegate GetStartDragging_IHandler ()
		{
			if (cb_startDragging_I == null)
				cb_startDragging_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_StartDragging_I);
			return cb_startDragging_I;
		}

		static void n_StartDragging_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DragAndDropHandler __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.DragAndDropHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartDragging (p0);
		}
#pragma warning restore 0169

		static IntPtr id_startDragging_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.dragdrop']/class[@name='DragAndDropHandler']/method[@name='startDragging' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("startDragging", "(I)V", "GetStartDragging_IHandler")]
		public virtual unsafe void StartDragging (int p0)
		{
			if (id_startDragging_I == IntPtr.Zero)
				id_startDragging_I = JNIEnv.GetMethodID (class_ref, "startDragging", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_startDragging_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startDragging", "(I)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IOnItemMovedListener"
		public event EventHandler<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.ItemMovedEventArgs> ItemMoved {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IOnItemMovedListener, global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IOnItemMovedListenerImplementor>(
						ref weak_implementor_SetOnItemMovedListener,
						__CreateIOnItemMovedListenerImplementor,
						SetOnItemMovedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IOnItemMovedListener, global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IOnItemMovedListenerImplementor>(
						ref weak_implementor_SetOnItemMovedListener,
						global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IOnItemMovedListenerImplementor.__IsEmpty,
						__v => SetOnItemMovedListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnItemMovedListener;

		global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IOnItemMovedListenerImplementor __CreateIOnItemMovedListenerImplementor ()
		{
			return new global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Dragdrop.IOnItemMovedListenerImplementor (this);
		}
#endregion
	}
}
