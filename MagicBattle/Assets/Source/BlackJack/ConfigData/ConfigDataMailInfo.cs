using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200025D RID: 605
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataMailInfo")]
	[Serializable]
	public class ConfigDataMailInfo : IExtensible
	{
		// Token: 0x06002695 RID: 9877 RVA: 0x000AA608 File Offset: 0x000A8808
		public ConfigDataMailInfo()
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

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x06002696 RID: 9878 RVA: 0x000AA67C File Offset: 0x000A887C
		// (set) Token: 0x06002697 RID: 9879 RVA: 0x000AA684 File Offset: 0x000A8884
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

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x06002698 RID: 9880 RVA: 0x000AA690 File Offset: 0x000A8890
		// (set) Token: 0x06002699 RID: 9881 RVA: 0x000AA698 File Offset: 0x000A8898
		[ProtoMember(3, IsRequired = true, Name = "Title", DataFormat = DataFormat.Default)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				this._Title = value;
			}
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x0600269A RID: 9882 RVA: 0x000AA6A4 File Offset: 0x000A88A4
		// (set) Token: 0x0600269B RID: 9883 RVA: 0x000AA6AC File Offset: 0x000A88AC
		[ProtoMember(4, IsRequired = true, Name = "Content", DataFormat = DataFormat.Default)]
		public string Content
		{
			get
			{
				return this._Content;
			}
			set
			{
				this._Content = value;
			}
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x0600269C RID: 9884 RVA: 0x000AA6B8 File Offset: 0x000A88B8
		[ProtoMember(5, Name = "Attachments", DataFormat = DataFormat.Default)]
		public List<Goods> Attachments
		{
			get
			{
				return this._Attachments;
			}
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x0600269D RID: 9885 RVA: 0x000AA6C0 File Offset: 0x000A88C0
		// (set) Token: 0x0600269E RID: 9886 RVA: 0x000AA6C8 File Offset: 0x000A88C8
		[ProtoMember(6, IsRequired = true, Name = "ExpiredTime", DataFormat = DataFormat.TwosComplement)]
		public uint ExpiredTime
		{
			get
			{
				return this._ExpiredTime;
			}
			set
			{
				this._ExpiredTime = value;
			}
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x0600269F RID: 9887 RVA: 0x000AA6D4 File Offset: 0x000A88D4
		// (set) Token: 0x060026A0 RID: 9888 RVA: 0x000AA6DC File Offset: 0x000A88DC
		[ProtoMember(7, IsRequired = true, Name = "ReadedExpiredTime", DataFormat = DataFormat.TwosComplement)]
		public int ReadedExpiredTime
		{
			get
			{
				return this._ReadedExpiredTime;
			}
			set
			{
				this._ReadedExpiredTime = value;
			}
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x060026A1 RID: 9889 RVA: 0x000AA6E8 File Offset: 0x000A88E8
		// (set) Token: 0x060026A2 RID: 9890 RVA: 0x000AA6F0 File Offset: 0x000A88F0
		[ProtoMember(8, IsRequired = true, Name = "GotDeleted", DataFormat = DataFormat.Default)]
		public bool GotDeleted
		{
			get
			{
				return this._GotDeleted;
			}
			set
			{
				this._GotDeleted = value;
			}
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x060026A3 RID: 9891 RVA: 0x000AA6FC File Offset: 0x000A88FC
		// (set) Token: 0x060026A4 RID: 9892 RVA: 0x000AA704 File Offset: 0x000A8904
		[ProtoMember(9, IsRequired = true, Name = "GameFunctionType", DataFormat = DataFormat.TwosComplement)]
		public GameFunctionType GameFunctionType
		{
			get
			{
				return this._GameFunctionType;
			}
			set
			{
				this._GameFunctionType = value;
			}
		}

		// Token: 0x060026A5 RID: 9893 RVA: 0x000AA710 File Offset: 0x000A8910
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060026A6 RID: 9894 RVA: 0x000AA720 File Offset: 0x000A8920
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

		// Token: 0x060026A7 RID: 9895 RVA: 0x000AA7EC File Offset: 0x000A89EC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataMailInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001799 RID: 6041
		private int _ID;

		// Token: 0x0400179A RID: 6042
		private string _Title;

		// Token: 0x0400179B RID: 6043
		private string _Content;

		// Token: 0x0400179C RID: 6044
		private readonly List<Goods> _Attachments = new List<Goods>();

		// Token: 0x0400179D RID: 6045
		private uint _ExpiredTime;

		// Token: 0x0400179E RID: 6046
		private int _ReadedExpiredTime;

		// Token: 0x0400179F RID: 6047
		private bool _GotDeleted;

		// Token: 0x040017A0 RID: 6048
		private GameFunctionType _GameFunctionType;

		// Token: 0x040017A1 RID: 6049
		private IExtension extensionObject;

		// Token: 0x040017A2 RID: 6050
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040017A3 RID: 6051
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040017A4 RID: 6052
		private LuaFunction m_ctor_hotfix;
	}
}
