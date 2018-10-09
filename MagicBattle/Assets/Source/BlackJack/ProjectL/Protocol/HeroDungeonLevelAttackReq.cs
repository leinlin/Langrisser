using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000799 RID: 1945
	[ProtoContract(Name = "HeroDungeonLevelAttackReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class HeroDungeonLevelAttackReq : IExtensible
	{
		// Token: 0x0600641E RID: 25630 RVA: 0x001C17E8 File Offset: 0x001BF9E8
		public HeroDungeonLevelAttackReq()
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

		// Token: 0x17001993 RID: 6547
		// (get) Token: 0x0600641F RID: 25631 RVA: 0x001C1850 File Offset: 0x001BFA50
		// (set) Token: 0x06006420 RID: 25632 RVA: 0x001C1858 File Offset: 0x001BFA58
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

		// Token: 0x06006421 RID: 25633 RVA: 0x001C1864 File Offset: 0x001BFA64
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006422 RID: 25634 RVA: 0x001C1874 File Offset: 0x001BFA74
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

		// Token: 0x06006423 RID: 25635 RVA: 0x001C1940 File Offset: 0x001BFB40
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroDungeonLevelAttackReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004B0D RID: 19213
		private int _LevelId;

		// Token: 0x04004B0E RID: 19214
		private IExtension extensionObject;

		// Token: 0x04004B0F RID: 19215
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004B10 RID: 19216
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004B11 RID: 19217
		private LuaFunction m_ctor_hotfix;
	}
}
