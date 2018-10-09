using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000225 RID: 549
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataCutsceneInfo")]
	[Serializable]
	public class ConfigDataCutsceneInfo : IExtensible
	{
		// Token: 0x060020AC RID: 8364 RVA: 0x000A0FC4 File Offset: 0x0009F1C4
		public ConfigDataCutsceneInfo()
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

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x060020AD RID: 8365 RVA: 0x000A102C File Offset: 0x0009F22C
		// (set) Token: 0x060020AE RID: 8366 RVA: 0x000A1034 File Offset: 0x0009F234
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

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x060020AF RID: 8367 RVA: 0x000A1040 File Offset: 0x0009F240
		// (set) Token: 0x060020B0 RID: 8368 RVA: 0x000A1048 File Offset: 0x0009F248
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

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x060020B1 RID: 8369 RVA: 0x000A1054 File Offset: 0x0009F254
		// (set) Token: 0x060020B2 RID: 8370 RVA: 0x000A105C File Offset: 0x0009F25C
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

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x060020B3 RID: 8371 RVA: 0x000A1068 File Offset: 0x0009F268
		// (set) Token: 0x060020B4 RID: 8372 RVA: 0x000A1070 File Offset: 0x0009F270
		[ProtoMember(5, IsRequired = true, Name = "Time", DataFormat = DataFormat.TwosComplement)]
		public int Time
		{
			get
			{
				return this._Time;
			}
			set
			{
				this._Time = value;
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x060020B5 RID: 8373 RVA: 0x000A107C File Offset: 0x0009F27C
		// (set) Token: 0x060020B6 RID: 8374 RVA: 0x000A1084 File Offset: 0x0009F284
		[ProtoMember(6, IsRequired = true, Name = "Fx", DataFormat = DataFormat.Default)]
		public string Fx
		{
			get
			{
				return this._Fx;
			}
			set
			{
				this._Fx = value;
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x060020B7 RID: 8375 RVA: 0x000A1090 File Offset: 0x0009F290
		// (set) Token: 0x060020B8 RID: 8376 RVA: 0x000A1098 File Offset: 0x0009F298
		[ProtoMember(7, IsRequired = true, Name = "Head", DataFormat = DataFormat.Default)]
		public string Head
		{
			get
			{
				return this._Head;
			}
			set
			{
				this._Head = value;
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x060020B9 RID: 8377 RVA: 0x000A10A4 File Offset: 0x0009F2A4
		// (set) Token: 0x060020BA RID: 8378 RVA: 0x000A10AC File Offset: 0x0009F2AC
		[ProtoMember(8, IsRequired = true, Name = "CameraAnimation", DataFormat = DataFormat.Default)]
		public string CameraAnimation
		{
			get
			{
				return this._CameraAnimation;
			}
			set
			{
				this._CameraAnimation = value;
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x060020BB RID: 8379 RVA: 0x000A10B8 File Offset: 0x0009F2B8
		// (set) Token: 0x060020BC RID: 8380 RVA: 0x000A10C0 File Offset: 0x0009F2C0
		[ProtoMember(9, IsRequired = true, Name = "Sound1", DataFormat = DataFormat.Default)]
		public string Sound1
		{
			get
			{
				return this._Sound1;
			}
			set
			{
				this._Sound1 = value;
			}
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x060020BD RID: 8381 RVA: 0x000A10CC File Offset: 0x0009F2CC
		// (set) Token: 0x060020BE RID: 8382 RVA: 0x000A10D4 File Offset: 0x0009F2D4
		[ProtoMember(10, IsRequired = true, Name = "Sound2", DataFormat = DataFormat.Default)]
		public string Sound2
		{
			get
			{
				return this._Sound2;
			}
			set
			{
				this._Sound2 = value;
			}
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x060020BF RID: 8383 RVA: 0x000A10E0 File Offset: 0x0009F2E0
		// (set) Token: 0x060020C0 RID: 8384 RVA: 0x000A10E8 File Offset: 0x0009F2E8
		[ProtoMember(11, IsRequired = true, Name = "Sound3", DataFormat = DataFormat.Default)]
		public string Sound3
		{
			get
			{
				return this._Sound3;
			}
			set
			{
				this._Sound3 = value;
			}
		}

		// Token: 0x060020C1 RID: 8385 RVA: 0x000A10F4 File Offset: 0x0009F2F4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060020C2 RID: 8386 RVA: 0x000A1104 File Offset: 0x0009F304
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

		// Token: 0x060020C3 RID: 8387 RVA: 0x000A11D0 File Offset: 0x0009F3D0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataCutsceneInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040013C2 RID: 5058
		private int _ID;

		// Token: 0x040013C3 RID: 5059
		private string _Name;

		// Token: 0x040013C4 RID: 5060
		private string _NameStrKey;

		// Token: 0x040013C5 RID: 5061
		private int _Time;

		// Token: 0x040013C6 RID: 5062
		private string _Fx;

		// Token: 0x040013C7 RID: 5063
		private string _Head;

		// Token: 0x040013C8 RID: 5064
		private string _CameraAnimation;

		// Token: 0x040013C9 RID: 5065
		private string _Sound1;

		// Token: 0x040013CA RID: 5066
		private string _Sound2;

		// Token: 0x040013CB RID: 5067
		private string _Sound3;

		// Token: 0x040013CC RID: 5068
		private IExtension extensionObject;

		// Token: 0x040013CD RID: 5069
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040013CE RID: 5070
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040013CF RID: 5071
		private LuaFunction m_ctor_hotfix;
	}
}
