using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000308 RID: 776
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BattlePosActor")]
	[Serializable]
	public class BattlePosActor : IExtensible
	{
		// Token: 0x06002E71 RID: 11889 RVA: 0x000B9ABC File Offset: 0x000B7CBC
		public BattlePosActor()
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

		// Token: 0x17000D0F RID: 3343
		// (get) Token: 0x06002E72 RID: 11890 RVA: 0x000B9B24 File Offset: 0x000B7D24
		// (set) Token: 0x06002E73 RID: 11891 RVA: 0x000B9B2C File Offset: 0x000B7D2C
		[ProtoMember(1, IsRequired = true, Name = "X", DataFormat = DataFormat.TwosComplement)]
		public int X
		{
			get
			{
				return this._X;
			}
			set
			{
				this._X = value;
			}
		}

		// Token: 0x17000D10 RID: 3344
		// (get) Token: 0x06002E74 RID: 11892 RVA: 0x000B9B38 File Offset: 0x000B7D38
		// (set) Token: 0x06002E75 RID: 11893 RVA: 0x000B9B40 File Offset: 0x000B7D40
		[ProtoMember(2, IsRequired = true, Name = "Y", DataFormat = DataFormat.TwosComplement)]
		public int Y
		{
			get
			{
				return this._Y;
			}
			set
			{
				this._Y = value;
			}
		}

		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x06002E76 RID: 11894 RVA: 0x000B9B4C File Offset: 0x000B7D4C
		// (set) Token: 0x06002E77 RID: 11895 RVA: 0x000B9B54 File Offset: 0x000B7D54
		[ProtoMember(3, IsRequired = true, Name = "ID", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x06002E78 RID: 11896 RVA: 0x000B9B60 File Offset: 0x000B7D60
		// (set) Token: 0x06002E79 RID: 11897 RVA: 0x000B9B68 File Offset: 0x000B7D68
		[ProtoMember(4, IsRequired = true, Name = "Level", DataFormat = DataFormat.TwosComplement)]
		public int Level
		{
			get
			{
				return this._Level;
			}
			set
			{
				this._Level = value;
			}
		}

		// Token: 0x06002E7A RID: 11898 RVA: 0x000B9B74 File Offset: 0x000B7D74
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002E7B RID: 11899 RVA: 0x000B9B84 File Offset: 0x000B7D84
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

		// Token: 0x06002E7C RID: 11900 RVA: 0x000B9C50 File Offset: 0x000B7E50
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattlePosActor));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040023A1 RID: 9121
		private int _X;

		// Token: 0x040023A2 RID: 9122
		private int _Y;

		// Token: 0x040023A3 RID: 9123
		private int _ID;

		// Token: 0x040023A4 RID: 9124
		private int _Level;

		// Token: 0x040023A5 RID: 9125
		private IExtension extensionObject;

		// Token: 0x040023A6 RID: 9126
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040023A7 RID: 9127
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040023A8 RID: 9128
		private LuaFunction m_ctor_hotfix;
	}
}
