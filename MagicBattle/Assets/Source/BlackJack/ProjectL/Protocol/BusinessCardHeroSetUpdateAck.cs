using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006D8 RID: 1752
	[ProtoContract(Name = "BusinessCardHeroSetUpdateAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class BusinessCardHeroSetUpdateAck : IExtensible
	{
		// Token: 0x06005E01 RID: 24065 RVA: 0x001AB3BC File Offset: 0x001A95BC
		public BusinessCardHeroSetUpdateAck()
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

		// Token: 0x170017E7 RID: 6119
		// (get) Token: 0x06005E02 RID: 24066 RVA: 0x001AB430 File Offset: 0x001A9630
		// (set) Token: 0x06005E03 RID: 24067 RVA: 0x001AB438 File Offset: 0x001A9638
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

		// Token: 0x170017E8 RID: 6120
		// (get) Token: 0x06005E04 RID: 24068 RVA: 0x001AB444 File Offset: 0x001A9644
		[ProtoMember(2, Name = "HeroSets", DataFormat = DataFormat.Default)]
		public List<ProBusinessCardHeroSet> HeroSets
		{
			get
			{
				return this._HeroSets;
			}
		}

		// Token: 0x06005E05 RID: 24069 RVA: 0x001AB44C File Offset: 0x001A964C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005E06 RID: 24070 RVA: 0x001AB45C File Offset: 0x001A965C
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

		// Token: 0x06005E07 RID: 24071 RVA: 0x001AB528 File Offset: 0x001A9728
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BusinessCardHeroSetUpdateAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400465D RID: 18013
		private int _Result;

		// Token: 0x0400465E RID: 18014
		private readonly List<ProBusinessCardHeroSet> _HeroSets = new List<ProBusinessCardHeroSet>();

		// Token: 0x0400465F RID: 18015
		private IExtension extensionObject;

		// Token: 0x04004660 RID: 18016
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004661 RID: 18017
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004662 RID: 18018
		private LuaFunction m_ctor_hotfix;
	}
}
