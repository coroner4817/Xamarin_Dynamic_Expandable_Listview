using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Nhaarman.Listviewanimations.Itemmanipulation.Animateaddition {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.animateaddition']/class[@name='InsertQueue']"
	[global::Android.Runtime.Register ("com/nhaarman/listviewanimations/itemmanipulation/animateaddition/InsertQueue", DoNotGenerateAcw=true)]
	public partial class InsertQueue : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/nhaarman/listviewanimations/itemmanipulation/animateaddition/InsertQueue", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InsertQueue); }
		}

		protected InsertQueue (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_nhaarman_listviewanimations_util_Insertable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.animateaddition']/class[@name='InsertQueue']/constructor[@name='InsertQueue' and count(parameter)=1 and parameter[1][@type='com.nhaarman.listviewanimations.util.Insertable&lt;T&gt;']]"
		[Register (".ctor", "(Lcom/nhaarman/listviewanimations/util/Insertable;)V", "")]
		public unsafe InsertQueue (global::Com.Nhaarman.Listviewanimations.Util.IInsertable p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (InsertQueue)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/nhaarman/listviewanimations/util/Insertable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/nhaarman/listviewanimations/util/Insertable;)V", __args);
					return;
				}

				if (id_ctor_Lcom_nhaarman_listviewanimations_util_Insertable_ == IntPtr.Zero)
					id_ctor_Lcom_nhaarman_listviewanimations_util_Insertable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/nhaarman/listviewanimations/util/Insertable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_nhaarman_listviewanimations_util_Insertable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_nhaarman_listviewanimations_util_Insertable_, __args);
			} finally {
			}
		}

		static Delegate cb_getActiveIndexes;
#pragma warning disable 0169
		static Delegate GetGetActiveIndexesHandler ()
		{
			if (cb_getActiveIndexes == null)
				cb_getActiveIndexes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetActiveIndexes);
			return cb_getActiveIndexes;
		}

		static IntPtr n_GetActiveIndexes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Animateaddition.InsertQueue __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Animateaddition.InsertQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaCollection<global::Java.Lang.Integer>.ToLocalJniHandle (__this.ActiveIndexes);
		}
#pragma warning restore 0169

		static IntPtr id_getActiveIndexes;
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Java.Lang.Integer> ActiveIndexes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.animateaddition']/class[@name='InsertQueue']/method[@name='getActiveIndexes' and count(parameter)=0]"
			[Register ("getActiveIndexes", "()Ljava/util/Collection;", "GetGetActiveIndexesHandler")]
			get {
				if (id_getActiveIndexes == IntPtr.Zero)
					id_getActiveIndexes = JNIEnv.GetMethodID (class_ref, "getActiveIndexes", "()Ljava/util/Collection;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaCollection<global::Java.Lang.Integer>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getActiveIndexes), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaCollection<global::Java.Lang.Integer>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getActiveIndexes", "()Ljava/util/Collection;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPendingItemsToInsert;
#pragma warning disable 0169
		static Delegate GetGetPendingItemsToInsertHandler ()
		{
			if (cb_getPendingItemsToInsert == null)
				cb_getPendingItemsToInsert = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPendingItemsToInsert);
			return cb_getPendingItemsToInsert;
		}

		static IntPtr n_GetPendingItemsToInsert (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Animateaddition.InsertQueue __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Animateaddition.InsertQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Android.Util.Pair>.ToLocalJniHandle (__this.PendingItemsToInsert);
		}
#pragma warning restore 0169

		static IntPtr id_getPendingItemsToInsert;
		public virtual unsafe global::System.Collections.Generic.IList<global::Android.Util.Pair> PendingItemsToInsert {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.animateaddition']/class[@name='InsertQueue']/method[@name='getPendingItemsToInsert' and count(parameter)=0]"
			[Register ("getPendingItemsToInsert", "()Ljava/util/List;", "GetGetPendingItemsToInsertHandler")]
			get {
				if (id_getPendingItemsToInsert == IntPtr.Zero)
					id_getPendingItemsToInsert = JNIEnv.GetMethodID (class_ref, "getPendingItemsToInsert", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Android.Util.Pair>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getPendingItemsToInsert), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Android.Util.Pair>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPendingItemsToInsert", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_clearActive;
#pragma warning disable 0169
		static Delegate GetClearActiveHandler ()
		{
			if (cb_clearActive == null)
				cb_clearActive = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearActive);
			return cb_clearActive;
		}

		static void n_ClearActive (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Animateaddition.InsertQueue __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Animateaddition.InsertQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearActive ();
		}
#pragma warning restore 0169

		static IntPtr id_clearActive;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.animateaddition']/class[@name='InsertQueue']/method[@name='clearActive' and count(parameter)=0]"
		[Register ("clearActive", "()V", "GetClearActiveHandler")]
		public virtual unsafe void ClearActive ()
		{
			if (id_clearActive == IntPtr.Zero)
				id_clearActive = JNIEnv.GetMethodID (class_ref, "clearActive", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clearActive);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearActive", "()V"));
			} finally {
			}
		}

		static Delegate cb_insert_arrayLandroid_util_Pair_;
#pragma warning disable 0169
		static Delegate GetInsert_arrayLandroid_util_Pair_Handler ()
		{
			if (cb_insert_arrayLandroid_util_Pair_ == null)
				cb_insert_arrayLandroid_util_Pair_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Insert_arrayLandroid_util_Pair_);
			return cb_insert_arrayLandroid_util_Pair_;
		}

		static void n_Insert_arrayLandroid_util_Pair_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Animateaddition.InsertQueue __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Animateaddition.InsertQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Util.Pair[] p0 = (global::Android.Util.Pair[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Android.Util.Pair));
			__this.Insert (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_insert_arrayLandroid_util_Pair_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.animateaddition']/class[@name='InsertQueue']/method[@name='insert' and count(parameter)=1 and parameter[1][@type='android.util.Pair&lt;java.lang.Integer, T&gt;...']]"
		[Register ("insert", "([Landroid/util/Pair;)V", "GetInsert_arrayLandroid_util_Pair_Handler")]
		public virtual unsafe void Insert (params global:: Android.Util.Pair[] p0)
		{
			if (id_insert_arrayLandroid_util_Pair_ == IntPtr.Zero)
				id_insert_arrayLandroid_util_Pair_ = JNIEnv.GetMethodID (class_ref, "insert", "([Landroid/util/Pair;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_insert_arrayLandroid_util_Pair_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "insert", "([Landroid/util/Pair;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_insert_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetInsert_ILjava_lang_Object_Handler ()
		{
			if (cb_insert_ILjava_lang_Object_ == null)
				cb_insert_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_Insert_ILjava_lang_Object_);
			return cb_insert_ILjava_lang_Object_;
		}

		static void n_Insert_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Animateaddition.InsertQueue __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Animateaddition.InsertQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Insert (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_insert_ILjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.animateaddition']/class[@name='InsertQueue']/method[@name='insert' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='T']]"
		[Register ("insert", "(ILjava/lang/Object;)V", "GetInsert_ILjava_lang_Object_Handler")]
		public virtual unsafe void Insert (int p0, global::Java.Lang.Object p1)
		{
			if (id_insert_ILjava_lang_Object_ == IntPtr.Zero)
				id_insert_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "insert", "(ILjava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_insert_ILjava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "insert", "(ILjava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_insert_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetInsert_Ljava_util_Collection_Handler ()
		{
			if (cb_insert_Ljava_util_Collection_ == null)
				cb_insert_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Insert_Ljava_util_Collection_);
			return cb_insert_Ljava_util_Collection_;
		}

		static void n_Insert_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Animateaddition.InsertQueue __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Animateaddition.InsertQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaCollection<global::Android.Util.Pair>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Insert (p0);
		}
#pragma warning restore 0169

		static IntPtr id_insert_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.animateaddition']/class[@name='InsertQueue']/method[@name='insert' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;android.util.Pair&lt;java.lang.Integer, T&gt;&gt;']]"
		[Register ("insert", "(Ljava/util/Collection;)V", "GetInsert_Ljava_util_Collection_Handler")]
		public virtual unsafe void Insert (global::System.Collections.Generic.ICollection<global::Android.Util.Pair> p0)
		{
			if (id_insert_Ljava_util_Collection_ == IntPtr.Zero)
				id_insert_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "insert", "(Ljava/util/Collection;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection<global::Android.Util.Pair>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_insert_Ljava_util_Collection_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "insert", "(Ljava/util/Collection;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_removeActiveIndex_I;
#pragma warning disable 0169
		static Delegate GetRemoveActiveIndex_IHandler ()
		{
			if (cb_removeActiveIndex_I == null)
				cb_removeActiveIndex_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_RemoveActiveIndex_I);
			return cb_removeActiveIndex_I;
		}

		static void n_RemoveActiveIndex_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Animateaddition.InsertQueue __this = global::Java.Lang.Object.GetObject<global::Com.Nhaarman.Listviewanimations.Itemmanipulation.Animateaddition.InsertQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveActiveIndex (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeActiveIndex_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.nhaarman.listviewanimations.itemmanipulation.animateaddition']/class[@name='InsertQueue']/method[@name='removeActiveIndex' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeActiveIndex", "(I)V", "GetRemoveActiveIndex_IHandler")]
		public virtual unsafe void RemoveActiveIndex (int p0)
		{
			if (id_removeActiveIndex_I == IntPtr.Zero)
				id_removeActiveIndex_I = JNIEnv.GetMethodID (class_ref, "removeActiveIndex", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_removeActiveIndex_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeActiveIndex", "(I)V"), __args);
			} finally {
			}
		}

	}
}
