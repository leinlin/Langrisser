using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000850 RID: 2128
	[ProtoContract(Name = "TreasureLevelAttackReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class TreasureLevelAttackReq : IExtensible
	{
		// Token: 0x06006A3D RID: 27197 RVA: 0x001DE014 File Offset: 0x001DC214
		public TreasureLevelAttackReq()
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

		// Token: 0x17001B4A RID: 6986
		// (get) Token: 0x06006A3E RID: 27198 RVA: 0x001DE07C File Offset: 0x001DC27C
		// (set) Token: 0x06006A3F RID: 27199 RVA: 0x001DE084 File Offset: 0x001DC284
		[ProtoMember(1, IsRequired = true, Name = "LevelId", DataFormat = DataFormat.TwosComplement)]
		public int LevelId
		{
			get
			{
				return this._LevelId;
			}
			set
			{
				this._LevelId = value;
			}
		}

		// Token: 0x06006A40 RID: 27200 RVA: 0x001DE090 File Offset: 0x001DC290
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006A41 RID: 27201 RVA: 0x001DE0A0 File Offset: 0x001DC2A0
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

		// Token: 0x06006A42 RID: 27202 RVA: 0x001DE16C File Offset: 0x001DC36C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TreasureLevelAttackReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040051E0 RID: 20960
		private int _LevelId;

		// Token: 0x040051E1 RID: 20961
		private IExtension extensionObject;

		// Token: 0x040051E2 RID: 20962
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040051E3 RID: 20963
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040051E4 RID: 20964
		private LuaFunction m_ctor_hotfix;
	}
}
