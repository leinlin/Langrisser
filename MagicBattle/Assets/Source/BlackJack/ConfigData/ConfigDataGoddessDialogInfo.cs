using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000239 RID: 569
	[CustomLuaClass]
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataGoddessDialogInfo")]
	[Serializable]
	public class ConfigDataGoddessDialogInfo : IExtensible
	{
		// Token: 0x060022E7 RID: 8935 RVA: 0x000A4640 File Offset: 0x000A2840
		public ConfigDataGoddessDialogInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctor_hotfix != null)
			{
				this.m_ctor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x060022E8 RID: 8936 RVA: 0x000A46C8 File Offset: 0x000A28C8
		// (set) Token: 0x060022E9 RID: 8937 RVA: 0x000A46D0 File Offset: 0x000A28D0
		[ProtoMember(2, IsRequired = true, Name = "ID", DataFormat = DataFormat.TwosComplement)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				this._ID = value;
			}
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x060022EA RID: 8938 RVA: 0x000A46DC File Offset: 0x000A28DC
		// (set) Token: 0x060022EB RID: 8939 RVA: 0x000A46E4 File Offset: 0x000A28E4
		[ProtoMember(3, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				this._Name = value;
			}
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x060022EC RID: 8940 RVA: 0x000A46F0 File Offset: 0x000A28F0
		// (set) Token: 0x060022ED RID: 8941 RVA: 0x000A46F8 File Offset: 0x000A28F8
		[ProtoMember(4, IsRequired = true, Name = "NameStrKey", DataFormat = DataFormat.Default)]
		public string NameStrKey
		{
			get
			{
				return this._NameStrKey;
			}
			set
			{
				this._NameStrKey = value;
			}
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x060022EE RID: 8942 RVA: 0x000A4704 File Offset: 0x000A2904
		// (set) Token: 0x060022EF RID: 8943 RVA: 0x000A470C File Offset: 0x000A290C
		[ProtoMember(5, IsRequired = true, Name = "NextDialog_ID", DataFormat = DataFormat.TwosComplement)]
		public int NextDialog_ID
		{
			get
			{
				return this._NextDialog_ID;
			}
			set
			{
				this._NextDialog_ID = value;
			}
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x060022F0 RID: 8944 RVA: 0x000A4718 File Offset: 0x000A2918
		// (set) Token: 0x060022F1 RID: 8945 RVA: 0x000A4720 File Offset: 0x000A2920
		[ProtoMember(6, IsRequired = true, Name = "PreAnimation", DataFormat = DataFormat.Default)]
		public string PreAnimation
		{
			get
			{
				return this._PreAnimation;
			}
			set
			{
				this._PreAnimation = value;
			}
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x060022F2 RID: 8946 RVA: 0x000A472C File Offset: 0x000A292C
		// (set) Token: 0x060022F3 RID: 8947 RVA: 0x000A4734 File Offset: 0x000A2934
		[ProtoMember(7, IsRequired = true, Name = "PreFacialAnimation", DataFormat = DataFormat.Default)]
		public string PreFacialAnimation
		{
			get
			{
				return this._PreFacialAnimation;
			}
			set
			{
				this._PreFacialAnimation = value;
			}
		}

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x060022F4 RID: 8948 RVA: 0x000A4740 File Offset: 0x000A2940
		// (set) Token: 0x060022F5 RID: 8949 RVA: 0x000A4748 File Offset: 0x000A2948
		[ProtoMember(8, IsRequired = true, Name = "IdleAnimation", DataFormat = DataFormat.Default)]
		public string IdleAnimation
		{
			get
			{
				return this._IdleAnimation;
			}
			set
			{
				this._IdleAnimation = value;
			}
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x060022F6 RID: 8950 RVA: 0x000A4754 File Offset: 0x000A2954
		// (set) Token: 0x060022F7 RID: 8951 RVA: 0x000A475C File Offset: 0x000A295C
		[ProtoMember(9, IsRequired = true, Name = "IdleFacialAnimation", DataFormat = DataFormat.Default)]
		public string IdleFacialAnimation
		{
			get
			{
				return this._IdleFacialAnimation;
			}
			set
			{
				this._IdleFacialAnimation = value;
			}
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x060022F8 RID: 8952 RVA: 0x000A4768 File Offset: 0x000A2968
		// (set) Token: 0x060022F9 RID: 8953 RVA: 0x000A4770 File Offset: 0x000A2970
		[ProtoMember(10, IsRequired = true, Name = "Voice", DataFormat = DataFormat.Default)]
		public string Voice
		{
			get
			{
				return this._Voice;
			}
			set
			{
				this._Voice = value;
			}
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x060022FA RID: 8954 RVA: 0x000A477C File Offset: 0x000A297C
		// (set) Token: 0x060022FB RID: 8955 RVA: 0x000A4784 File Offset: 0x000A2984
		[ProtoMember(11, IsRequired = true, Name = "Words", DataFormat = DataFormat.Default)]
		public string Words
		{
			get
			{
				return this._Words;
			}
			set
			{
				this._Words = value;
			}
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x060022FC RID: 8956 RVA: 0x000A4790 File Offset: 0x000A2990
		// (set) Token: 0x060022FD RID: 8957 RVA: 0x000A4798 File Offset: 0x000A2998
		[ProtoMember(12, IsRequired = true, Name = "WordsKey", DataFormat = DataFormat.Default)]
		public string WordsKey
		{
			get
			{
				return this._WordsKey;
			}
			set
			{
				this._WordsKey = value;
			}
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x060022FE RID: 8958 RVA: 0x000A47A4 File Offset: 0x000A29A4
		// (set) Token: 0x060022FF RID: 8959 RVA: 0x000A47AC File Offset: 0x000A29AC
		[ProtoMember(13, IsRequired = true, Name = "FeedbackVoice1", DataFormat = DataFormat.Default)]
		public string FeedbackVoice1
		{
			get
			{
				return this._FeedbackVoice1;
			}
			set
			{
				this._FeedbackVoice1 = value;
			}
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06002300 RID: 8960 RVA: 0x000A47B8 File Offset: 0x000A29B8
		// (set) Token: 0x06002301 RID: 8961 RVA: 0x000A47C0 File Offset: 0x000A29C0
		[ProtoMember(14, IsRequired = true, Name = "FeedbackVoice2", DataFormat = DataFormat.Default)]
		public string FeedbackVoice2
		{
			get
			{
				return this._FeedbackVoice2;
			}
			set
			{
				this._FeedbackVoice2 = value;
			}
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x06002302 RID: 8962 RVA: 0x000A47CC File Offset: 0x000A29CC
		// (set) Token: 0x06002303 RID: 8963 RVA: 0x000A47D4 File Offset: 0x000A29D4
		[ProtoMember(15, IsRequired = true, Name = "FeedbackVoice3", DataFormat = DataFormat.Default)]
		public string FeedbackVoice3
		{
			get
			{
				return this._FeedbackVoice3;
			}
			set
			{
				this._FeedbackVoice3 = value;
			}
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x06002304 RID: 8964 RVA: 0x000A47E0 File Offset: 0x000A29E0
		// (set) Token: 0x06002305 RID: 8965 RVA: 0x000A47E8 File Offset: 0x000A29E8
		[ProtoMember(16, IsRequired = true, Name = "FeedbackText1", DataFormat = DataFormat.Default)]
		public string FeedbackText1
		{
			get
			{
				return this._FeedbackText1;
			}
			set
			{
				this._FeedbackText1 = value;
			}
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x06002306 RID: 8966 RVA: 0x000A47F4 File Offset: 0x000A29F4
		// (set) Token: 0x06002307 RID: 8967 RVA: 0x000A47FC File Offset: 0x000A29FC
		[ProtoMember(17, IsRequired = true, Name = "FeedbackText2", DataFormat = DataFormat.Default)]
		public string FeedbackText2
		{
			get
			{
				return this._FeedbackText2;
			}
			set
			{
				this._FeedbackText2 = value;
			}
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x06002308 RID: 8968 RVA: 0x000A4808 File Offset: 0x000A2A08
		// (set) Token: 0x06002309 RID: 8969 RVA: 0x000A4810 File Offset: 0x000A2A10
		[ProtoMember(18, IsRequired = true, Name = "FeedbackText3", DataFormat = DataFormat.Default)]
		public string FeedbackText3
		{
			get
			{
				return this._FeedbackText3;
			}
			set
			{
				this._FeedbackText3 = value;
			}
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x0600230A RID: 8970 RVA: 0x000A481C File Offset: 0x000A2A1C
		// (set) Token: 0x0600230B RID: 8971 RVA: 0x000A4824 File Offset: 0x000A2A24
		[ProtoMember(19, IsRequired = true, Name = "Choice1Text", DataFormat = DataFormat.Default)]
		public string Choice1Text
		{
			get
			{
				return this._Choice1Text;
			}
			set
			{
				this._Choice1Text = value;
			}
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x0600230C RID: 8972 RVA: 0x000A4830 File Offset: 0x000A2A30
		// (set) Token: 0x0600230D RID: 8973 RVA: 0x000A4838 File Offset: 0x000A2A38
		[ProtoMember(20, IsRequired = true, Name = "Choice1TextKey", DataFormat = DataFormat.Default)]
		public string Choice1TextKey
		{
			get
			{
				return this._Choice1TextKey;
			}
			set
			{
				this._Choice1TextKey = value;
			}
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x0600230E RID: 8974 RVA: 0x000A4844 File Offset: 0x000A2A44
		// (set) Token: 0x0600230F RID: 8975 RVA: 0x000A484C File Offset: 0x000A2A4C
		[ProtoMember(21, IsRequired = true, Name = "Choice1NextDialog_ID", DataFormat = DataFormat.TwosComplement)]
		public int Choice1NextDialog_ID
		{
			get
			{
				return this._Choice1NextDialog_ID;
			}
			set
			{
				this._Choice1NextDialog_ID = value;
			}
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x06002310 RID: 8976 RVA: 0x000A4858 File Offset: 0x000A2A58
		[ProtoMember(22, Name = "Choice1Value", DataFormat = DataFormat.Default)]
		public List<ChoiceValue> Choice1Value
		{
			get
			{
				return this._Choice1Value;
			}
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x06002311 RID: 8977 RVA: 0x000A4860 File Offset: 0x000A2A60
		// (set) Token: 0x06002312 RID: 8978 RVA: 0x000A4868 File Offset: 0x000A2A68
		[ProtoMember(23, IsRequired = true, Name = "Choice2Text", DataFormat = DataFormat.Default)]
		public string Choice2Text
		{
			get
			{
				return this._Choice2Text;
			}
			set
			{
				this._Choice2Text = value;
			}
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x06002313 RID: 8979 RVA: 0x000A4874 File Offset: 0x000A2A74
		// (set) Token: 0x06002314 RID: 8980 RVA: 0x000A487C File Offset: 0x000A2A7C
		[ProtoMember(24, IsRequired = true, Name = "Choice2TextKey", DataFormat = DataFormat.Default)]
		public string Choice2TextKey
		{
			get
			{
				return this._Choice2TextKey;
			}
			set
			{
				this._Choice2TextKey = value;
			}
		}

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x06002315 RID: 8981 RVA: 0x000A4888 File Offset: 0x000A2A88
		// (set) Token: 0x06002316 RID: 8982 RVA: 0x000A4890 File Offset: 0x000A2A90
		[ProtoMember(25, IsRequired = true, Name = "Choice2NextDialog_ID", DataFormat = DataFormat.TwosComplement)]
		public int Choice2NextDialog_ID
		{
			get
			{
				return this._Choice2NextDialog_ID;
			}
			set
			{
				this._Choice2NextDialog_ID = value;
			}
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x06002317 RID: 8983 RVA: 0x000A489C File Offset: 0x000A2A9C
		[ProtoMember(26, Name = "Choice2Value", DataFormat = DataFormat.Default)]
		public List<ChoiceValue> Choice2Value
		{
			get
			{
				return this._Choice2Value;
			}
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x06002318 RID: 8984 RVA: 0x000A48A4 File Offset: 0x000A2AA4
		// (set) Token: 0x06002319 RID: 8985 RVA: 0x000A48AC File Offset: 0x000A2AAC
		[ProtoMember(27, IsRequired = true, Name = "Choice3Text", DataFormat = DataFormat.Default)]
		public string Choice3Text
		{
			get
			{
				return this._Choice3Text;
			}
			set
			{
				this._Choice3Text = value;
			}
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x0600231A RID: 8986 RVA: 0x000A48B8 File Offset: 0x000A2AB8
		// (set) Token: 0x0600231B RID: 8987 RVA: 0x000A48C0 File Offset: 0x000A2AC0
		[ProtoMember(28, IsRequired = true, Name = "Choice3TextKey", DataFormat = DataFormat.Default)]
		public string Choice3TextKey
		{
			get
			{
				return this._Choice3TextKey;
			}
			set
			{
				this._Choice3TextKey = value;
			}
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x0600231C RID: 8988 RVA: 0x000A48CC File Offset: 0x000A2ACC
		// (set) Token: 0x0600231D RID: 8989 RVA: 0x000A48D4 File Offset: 0x000A2AD4
		[ProtoMember(29, IsRequired = true, Name = "Choice3NextDialog_ID", DataFormat = DataFormat.TwosComplement)]
		public int Choice3NextDialog_ID
		{
			get
			{
				return this._Choice3NextDialog_ID;
			}
			set
			{
				this._Choice3NextDialog_ID = value;
			}
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x0600231E RID: 8990 RVA: 0x000A48E0 File Offset: 0x000A2AE0
		[ProtoMember(30, Name = "Choice3Value", DataFormat = DataFormat.Default)]
		public List<ChoiceValue> Choice3Value
		{
			get
			{
				return this._Choice3Value;
			}
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x0600231F RID: 8991 RVA: 0x000A48E8 File Offset: 0x000A2AE8
		// (set) Token: 0x06002320 RID: 8992 RVA: 0x000A48F0 File Offset: 0x000A2AF0
		[ProtoMember(31, IsRequired = true, Name = "FunctionType", DataFormat = DataFormat.TwosComplement)]
		public GoddessDialogFuncType FunctionType
		{
			get
			{
				return this._FunctionType;
			}
			set
			{
				this._FunctionType = value;
			}
		}

		// Token: 0x06002321 RID: 8993 RVA: 0x000A48FC File Offset: 0x000A2AFC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002322 RID: 8994 RVA: 0x000A490C File Offset: 0x000A2B0C
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				Debug.LogError("Can't find HotFixObject Func");
				result = false;
			}
			else
			{
				luaFunction.call(new object[]
				{
					this,
					this.m_luaObjHelper
				});
				LuaTable luaObj = this.m_luaObjHelper.GetLuaObj();
				if (luaObj == null)
				{
					result = false;
				}
				else
				{
					this.m_ctor_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06002323 RID: 8995 RVA: 0x000A49D8 File Offset: 0x000A2BD8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataGoddessDialogInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001521 RID: 5409
		private int _ID;

		// Token: 0x04001522 RID: 5410
		private string _Name;

		// Token: 0x04001523 RID: 5411
		private string _NameStrKey;

		// Token: 0x04001524 RID: 5412
		private int _NextDialog_ID;

		// Token: 0x04001525 RID: 5413
		private string _PreAnimation;

		// Token: 0x04001526 RID: 5414
		private string _PreFacialAnimation;

		// Token: 0x04001527 RID: 5415
		private string _IdleAnimation;

		// Token: 0x04001528 RID: 5416
		private string _IdleFacialAnimation;

		// Token: 0x04001529 RID: 5417
		private string _Voice;

		// Token: 0x0400152A RID: 5418
		private string _Words;

		// Token: 0x0400152B RID: 5419
		private string _WordsKey;

		// Token: 0x0400152C RID: 5420
		private string _FeedbackVoice1;

		// Token: 0x0400152D RID: 5421
		private string _FeedbackVoice2;

		// Token: 0x0400152E RID: 5422
		private string _FeedbackVoice3;

		// Token: 0x0400152F RID: 5423
		private string _FeedbackText1;

		// Token: 0x04001530 RID: 5424
		private string _FeedbackText2;

		// Token: 0x04001531 RID: 5425
		private string _FeedbackText3;

		// Token: 0x04001532 RID: 5426
		private string _Choice1Text;

		// Token: 0x04001533 RID: 5427
		private string _Choice1TextKey;

		// Token: 0x04001534 RID: 5428
		private int _Choice1NextDialog_ID;

		// Token: 0x04001535 RID: 5429
		private readonly List<ChoiceValue> _Choice1Value = new List<ChoiceValue>();

		// Token: 0x04001536 RID: 5430
		private string _Choice2Text;

		// Token: 0x04001537 RID: 5431
		private string _Choice2TextKey;

		// Token: 0x04001538 RID: 5432
		private int _Choice2NextDialog_ID;

		// Token: 0x04001539 RID: 5433
		private readonly List<ChoiceValue> _Choice2Value = new List<ChoiceValue>();

		// Token: 0x0400153A RID: 5434
		private string _Choice3Text;

		// Token: 0x0400153B RID: 5435
		private string _Choice3TextKey;

		// Token: 0x0400153C RID: 5436
		private int _Choice3NextDialog_ID;

		// Token: 0x0400153D RID: 5437
		private readonly List<ChoiceValue> _Choice3Value = new List<ChoiceValue>();

		// Token: 0x0400153E RID: 5438
		private GoddessDialogFuncType _FunctionType;

		// Token: 0x0400153F RID: 5439
		private IExtension extensionObject;

		// Token: 0x04001540 RID: 5440
		public ConfigDataGoddessDialogInfo m_nextDialogInfo;

		// Token: 0x04001541 RID: 5441
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001542 RID: 5442
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001543 RID: 5443
		private LuaFunction m_ctor_hotfix;
	}
}
