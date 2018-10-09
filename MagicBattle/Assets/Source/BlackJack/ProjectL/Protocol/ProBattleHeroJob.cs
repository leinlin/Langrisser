using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200065D RID: 1629
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProBattleHeroJob")]
	[Serializable]
	public class ProBattleHeroJob : IExtensible
	{
		// Token: 0x060058E5 RID: 22757 RVA: 0x0019C334 File Offset: 0x0019A534
		public ProBattleHeroJob()
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

		// Token: 0x17001628 RID: 5672
		// (get) Token: 0x060058E6 RID: 22758 RVA: 0x0019C39C File Offset: 0x0019A59C
		// (set) Token: 0x060058E7 RID: 22759 RVA: 0x0019C3A4 File Offset: 0x0019A5A4
		[ProtoMember(1, IsRequired = true, Name = "JobRelatedId", DataFormat = DataFormat.TwosComplement)]
		public int JobRelatedId
		{
			get
			{
				return this._JobRelatedId;
			}
			set
			{
				this._JobRelatedId = value;
			}
		}

		// Token: 0x17001629 RID: 5673
		// (get) Token: 0x060058E8 RID: 22760 RVA: 0x0019C3B0 File Offset: 0x0019A5B0
		// (set) Token: 0x060058E9 RID: 22761 RVA: 0x0019C3B8 File Offset: 0x0019A5B8
		[ProtoMember(2, IsRequired = true, Name = "JobLevel", DataFormat = DataFormat.TwosComplement)]
		public int JobLevel
		{
			get
			{
				return this._JobLevel;
			}
			set
			{
				this._JobLevel = value;
			}
		}

		// Token: 0x060058EA RID: 22762 RVA: 0x0019C3C4 File Offset: 0x0019A5C4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060058EB RID: 22763 RVA: 0x0019C3D4 File Offset: 0x0019A5D4
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

		// Token: 0x060058EC RID: 22764 RVA: 0x0019C4A0 File Offset: 0x0019A6A0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProBattleHeroJob));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040042B2 RID: 17074
		private int _JobRelatedId;

		// Token: 0x040042B3 RID: 17075
		private int _JobLevel;

		// Token: 0x040042B4 RID: 17076
		private IExtension extensionObject;

		// Token: 0x040042B5 RID: 17077
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040042B6 RID: 17078
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040042B7 RID: 17079
		private LuaFunction m_ctor_hotfix;
	}
}
