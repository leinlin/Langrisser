using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200065A RID: 1626
	[ProtoContract(Name = "ProArenaPlayerDefensiveHero")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProArenaPlayerDefensiveHero : IExtensible
	{
		// Token: 0x060058AB RID: 22699 RVA: 0x0019BC30 File Offset: 0x00199E30
		public ProArenaPlayerDefensiveHero()
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

		// Token: 0x1700160E RID: 5646
		// (get) Token: 0x060058AC RID: 22700 RVA: 0x0019BC98 File Offset: 0x00199E98
		// (set) Token: 0x060058AD RID: 22701 RVA: 0x0019BCA0 File Offset: 0x00199EA0
		[ProtoMember(1, IsRequired = true, Name = "HeroId", DataFormat = DataFormat.TwosComplement)]
		public int HeroId
		{
			get
			{
				return this._HeroId;
			}
			set
			{
				this._HeroId = value;
			}
		}

		// Token: 0x1700160F RID: 5647
		// (get) Token: 0x060058AE RID: 22702 RVA: 0x0019BCAC File Offset: 0x00199EAC
		// (set) Token: 0x060058AF RID: 22703 RVA: 0x0019BCB4 File Offset: 0x00199EB4
		[ProtoMember(2, IsRequired = true, Name = "ActionPositionIndex", DataFormat = DataFormat.TwosComplement)]
		public int ActionPositionIndex
		{
			get
			{
				return this._ActionPositionIndex;
			}
			set
			{
				this._ActionPositionIndex = value;
			}
		}

		// Token: 0x17001610 RID: 5648
		// (get) Token: 0x060058B0 RID: 22704 RVA: 0x0019BCC0 File Offset: 0x00199EC0
		// (set) Token: 0x060058B1 RID: 22705 RVA: 0x0019BCC8 File Offset: 0x00199EC8
		[ProtoMember(3, IsRequired = true, Name = "ActionValue", DataFormat = DataFormat.TwosComplement)]
		public int ActionValue
		{
			get
			{
				return this._ActionValue;
			}
			set
			{
				this._ActionValue = value;
			}
		}

		// Token: 0x060058B2 RID: 22706 RVA: 0x0019BCD4 File Offset: 0x00199ED4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060058B3 RID: 22707 RVA: 0x0019BCE4 File Offset: 0x00199EE4
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

		// Token: 0x060058B4 RID: 22708 RVA: 0x0019BDB0 File Offset: 0x00199FB0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProArenaPlayerDefensiveHero));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400428C RID: 17036
		private int _HeroId;

		// Token: 0x0400428D RID: 17037
		private int _ActionPositionIndex;

		// Token: 0x0400428E RID: 17038
		private int _ActionValue;

		// Token: 0x0400428F RID: 17039
		private IExtension extensionObject;

		// Token: 0x04004290 RID: 17040
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004291 RID: 17041
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004292 RID: 17042
		private LuaFunction m_ctor_hotfix;
	}
}
