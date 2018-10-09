using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007A8 RID: 1960
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "HeroStarLevelLevelUpAck")]
	[Serializable]
	public class HeroStarLevelLevelUpAck : IExtensible
	{
		// Token: 0x060064B1 RID: 25777 RVA: 0x001C34B0 File Offset: 0x001C16B0
		public HeroStarLevelLevelUpAck()
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

		// Token: 0x170019C3 RID: 6595
		// (get) Token: 0x060064B2 RID: 25778 RVA: 0x001C3518 File Offset: 0x001C1718
		// (set) Token: 0x060064B3 RID: 25779 RVA: 0x001C3520 File Offset: 0x001C1720
		[ProtoMember(1, IsRequired = true, Name = "Result", DataFormat = DataFormat.TwosComplement)]
		public int Result
		{
			get
			{
				return this._Result;
			}
			set
			{
				this._Result = value;
			}
		}

		// Token: 0x170019C4 RID: 6596
		// (get) Token: 0x060064B4 RID: 25780 RVA: 0x001C352C File Offset: 0x001C172C
		// (set) Token: 0x060064B5 RID: 25781 RVA: 0x001C3534 File Offset: 0x001C1734
		[ProtoMember(2, IsRequired = true, Name = "HeroId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x060064B6 RID: 25782 RVA: 0x001C3540 File Offset: 0x001C1740
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060064B7 RID: 25783 RVA: 0x001C3550 File Offset: 0x001C1750
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

		// Token: 0x060064B8 RID: 25784 RVA: 0x001C361C File Offset: 0x001C181C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroStarLevelLevelUpAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004B79 RID: 19321
		private int _Result;

		// Token: 0x04004B7A RID: 19322
		private int _HeroId;

		// Token: 0x04004B7B RID: 19323
		private IExtension extensionObject;

		// Token: 0x04004B7C RID: 19324
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004B7D RID: 19325
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004B7E RID: 19326
		private LuaFunction m_ctor_hotfix;
	}
}
