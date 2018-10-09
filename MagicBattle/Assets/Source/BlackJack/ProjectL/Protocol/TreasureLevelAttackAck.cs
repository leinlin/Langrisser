using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000851 RID: 2129
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "TreasureLevelAttackAck")]
	[Serializable]
	public class TreasureLevelAttackAck : IExtensible
	{
		// Token: 0x06006A43 RID: 27203 RVA: 0x001DE1D4 File Offset: 0x001DC3D4
		public TreasureLevelAttackAck()
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

		// Token: 0x17001B4B RID: 6987
		// (get) Token: 0x06006A44 RID: 27204 RVA: 0x001DE23C File Offset: 0x001DC43C
		// (set) Token: 0x06006A45 RID: 27205 RVA: 0x001DE244 File Offset: 0x001DC444
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

		// Token: 0x17001B4C RID: 6988
		// (get) Token: 0x06006A46 RID: 27206 RVA: 0x001DE250 File Offset: 0x001DC450
		// (set) Token: 0x06006A47 RID: 27207 RVA: 0x001DE258 File Offset: 0x001DC458
		[ProtoMember(2, IsRequired = true, Name = "LevelId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001B4D RID: 6989
		// (get) Token: 0x06006A48 RID: 27208 RVA: 0x001DE264 File Offset: 0x001DC464
		// (set) Token: 0x06006A49 RID: 27209 RVA: 0x001DE26C File Offset: 0x001DC46C
		[ProtoMember(3, IsRequired = true, Name = "BattleBeginInfo", DataFormat = DataFormat.Default)]
		public ProBattleBeginInfo BattleBeginInfo
		{
			get
			{
				return this._BattleBeginInfo;
			}
			set
			{
				this._BattleBeginInfo = value;
			}
		}

		// Token: 0x06006A4A RID: 27210 RVA: 0x001DE278 File Offset: 0x001DC478
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006A4B RID: 27211 RVA: 0x001DE288 File Offset: 0x001DC488
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

		// Token: 0x06006A4C RID: 27212 RVA: 0x001DE354 File Offset: 0x001DC554
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TreasureLevelAttackAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040051E5 RID: 20965
		private int _Result;

		// Token: 0x040051E6 RID: 20966
		private int _LevelId;

		// Token: 0x040051E7 RID: 20967
		private ProBattleBeginInfo _BattleBeginInfo;

		// Token: 0x040051E8 RID: 20968
		private IExtension extensionObject;

		// Token: 0x040051E9 RID: 20969
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040051EA RID: 20970
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040051EB RID: 20971
		private LuaFunction m_ctor_hotfix;
	}
}
