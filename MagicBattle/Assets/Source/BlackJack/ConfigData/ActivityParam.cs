using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000311 RID: 785
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ActivityParam")]
	[Serializable]
	public class ActivityParam : IExtensible
	{
		// Token: 0x06002ED1 RID: 11985 RVA: 0x000BAC20 File Offset: 0x000B8E20
		public ActivityParam()
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

		// Token: 0x17000D2D RID: 3373
		// (get) Token: 0x06002ED2 RID: 11986 RVA: 0x000BAC88 File Offset: 0x000B8E88
		// (set) Token: 0x06002ED3 RID: 11987 RVA: 0x000BAC90 File Offset: 0x000B8E90
		[ProtoMember(1, IsRequired = true, Name = "Parm1", DataFormat = DataFormat.TwosComplement)]
		public int Parm1
		{
			get
			{
				return this._Parm1;
			}
			set
			{
				this._Parm1 = value;
			}
		}

		// Token: 0x17000D2E RID: 3374
		// (get) Token: 0x06002ED4 RID: 11988 RVA: 0x000BAC9C File Offset: 0x000B8E9C
		// (set) Token: 0x06002ED5 RID: 11989 RVA: 0x000BACA4 File Offset: 0x000B8EA4
		[ProtoMember(2, IsRequired = true, Name = "Parm2", DataFormat = DataFormat.TwosComplement)]
		public int Parm2
		{
			get
			{
				return this._Parm2;
			}
			set
			{
				this._Parm2 = value;
			}
		}

		// Token: 0x17000D2F RID: 3375
		// (get) Token: 0x06002ED6 RID: 11990 RVA: 0x000BACB0 File Offset: 0x000B8EB0
		// (set) Token: 0x06002ED7 RID: 11991 RVA: 0x000BACB8 File Offset: 0x000B8EB8
		[ProtoMember(3, IsRequired = true, Name = "Parm3", DataFormat = DataFormat.TwosComplement)]
		public int Parm3
		{
			get
			{
				return this._Parm3;
			}
			set
			{
				this._Parm3 = value;
			}
		}

		// Token: 0x06002ED8 RID: 11992 RVA: 0x000BACC4 File Offset: 0x000B8EC4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002ED9 RID: 11993 RVA: 0x000BACD4 File Offset: 0x000B8ED4
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

		// Token: 0x06002EDA RID: 11994 RVA: 0x000BADA0 File Offset: 0x000B8FA0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ActivityParam));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040023E3 RID: 9187
		private int _Parm1;

		// Token: 0x040023E4 RID: 9188
		private int _Parm2;

		// Token: 0x040023E5 RID: 9189
		private int _Parm3;

		// Token: 0x040023E6 RID: 9190
		private IExtension extensionObject;

		// Token: 0x040023E7 RID: 9191
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040023E8 RID: 9192
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040023E9 RID: 9193
		private LuaFunction m_ctor_hotfix;
	}
}
