using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000752 RID: 1874
	[ProtoContract(Name = "GuildCreateReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class GuildCreateReq : IExtensible
	{
		// Token: 0x06006212 RID: 25106 RVA: 0x001B9764 File Offset: 0x001B7964
		public GuildCreateReq()
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

		// Token: 0x17001917 RID: 6423
		// (get) Token: 0x06006213 RID: 25107 RVA: 0x001B97D8 File Offset: 0x001B79D8
		// (set) Token: 0x06006214 RID: 25108 RVA: 0x001B97E0 File Offset: 0x001B79E0
		[ProtoMember(1, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
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

		// Token: 0x17001918 RID: 6424
		// (get) Token: 0x06006215 RID: 25109 RVA: 0x001B97EC File Offset: 0x001B79EC
		// (set) Token: 0x06006216 RID: 25110 RVA: 0x001B97F4 File Offset: 0x001B79F4
		[DefaultValue("")]
		[ProtoMember(2, IsRequired = false, Name = "HiringDeclaration", DataFormat = DataFormat.Default)]
		public string HiringDeclaration
		{
			get
			{
				return this._HiringDeclaration;
			}
			set
			{
				this._HiringDeclaration = value;
			}
		}

		// Token: 0x17001919 RID: 6425
		// (get) Token: 0x06006217 RID: 25111 RVA: 0x001B9800 File Offset: 0x001B7A00
		// (set) Token: 0x06006218 RID: 25112 RVA: 0x001B9808 File Offset: 0x001B7A08
		[ProtoMember(3, IsRequired = true, Name = "AutoJoin", DataFormat = DataFormat.Default)]
		public bool AutoJoin
		{
			get
			{
				return this._AutoJoin;
			}
			set
			{
				this._AutoJoin = value;
			}
		}

		// Token: 0x1700191A RID: 6426
		// (get) Token: 0x06006219 RID: 25113 RVA: 0x001B9814 File Offset: 0x001B7A14
		// (set) Token: 0x0600621A RID: 25114 RVA: 0x001B981C File Offset: 0x001B7A1C
		[ProtoMember(4, IsRequired = true, Name = "JoinLevel", DataFormat = DataFormat.TwosComplement)]
		public int JoinLevel
		{
			get
			{
				return this._JoinLevel;
			}
			set
			{
				this._JoinLevel = value;
			}
		}

		// Token: 0x1700191B RID: 6427
		// (get) Token: 0x0600621B RID: 25115 RVA: 0x001B9828 File Offset: 0x001B7A28
		// (set) Token: 0x0600621C RID: 25116 RVA: 0x001B9830 File Offset: 0x001B7A30
		[ProtoMember(5, IsRequired = true, Name = "Announcement", DataFormat = DataFormat.Default)]
		public string Announcement
		{
			get
			{
				return this._Announcement;
			}
			set
			{
				this._Announcement = value;
			}
		}

		// Token: 0x0600621D RID: 25117 RVA: 0x001B983C File Offset: 0x001B7A3C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600621E RID: 25118 RVA: 0x001B984C File Offset: 0x001B7A4C
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

		// Token: 0x0600621F RID: 25119 RVA: 0x001B9918 File Offset: 0x001B7B18
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildCreateReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004975 RID: 18805
		private string _Name;

		// Token: 0x04004976 RID: 18806
		private string _HiringDeclaration = string.Empty;

		// Token: 0x04004977 RID: 18807
		private bool _AutoJoin;

		// Token: 0x04004978 RID: 18808
		private int _JoinLevel;

		// Token: 0x04004979 RID: 18809
		private string _Announcement;

		// Token: 0x0400497A RID: 18810
		private IExtension extensionObject;

		// Token: 0x0400497B RID: 18811
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400497C RID: 18812
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400497D RID: 18813
		private LuaFunction m_ctor_hotfix;
	}
}
