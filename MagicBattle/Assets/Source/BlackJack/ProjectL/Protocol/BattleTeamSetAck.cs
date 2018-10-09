using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005E1 RID: 1505
	[ProtoContract(Name = "BattleTeamSetAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class BattleTeamSetAck : IExtensible
	{
		// Token: 0x06005431 RID: 21553 RVA: 0x0018D5A8 File Offset: 0x0018B7A8
		public BattleTeamSetAck()
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

		// Token: 0x170014A8 RID: 5288
		// (get) Token: 0x06005432 RID: 21554 RVA: 0x0018D61C File Offset: 0x0018B81C
		// (set) Token: 0x06005433 RID: 21555 RVA: 0x0018D624 File Offset: 0x0018B824
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

		// Token: 0x170014A9 RID: 5289
		// (get) Token: 0x06005434 RID: 21556 RVA: 0x0018D630 File Offset: 0x0018B830
		// (set) Token: 0x06005435 RID: 21557 RVA: 0x0018D638 File Offset: 0x0018B838
		[ProtoMember(2, IsRequired = true, Name = "BattleId", DataFormat = DataFormat.TwosComplement)]
		public int BattleId
		{
			get
			{
				return this._BattleId;
			}
			set
			{
				this._BattleId = value;
			}
		}

		// Token: 0x170014AA RID: 5290
		// (get) Token: 0x06005436 RID: 21558 RVA: 0x0018D644 File Offset: 0x0018B844
		// (set) Token: 0x06005437 RID: 21559 RVA: 0x0018D64C File Offset: 0x0018B84C
		[ProtoMember(3, IsRequired = true, Name = "BattleType", DataFormat = DataFormat.TwosComplement)]
		public int BattleType
		{
			get
			{
				return this._BattleType;
			}
			set
			{
				this._BattleType = value;
			}
		}

		// Token: 0x170014AB RID: 5291
		// (get) Token: 0x06005438 RID: 21560 RVA: 0x0018D658 File Offset: 0x0018B858
		[ProtoMember(4, Name = "HeroIds", DataFormat = DataFormat.TwosComplement)]
		public List<int> HeroIds
		{
			get
			{
				return this._HeroIds;
			}
		}

		// Token: 0x06005439 RID: 21561 RVA: 0x0018D660 File Offset: 0x0018B860
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600543A RID: 21562 RVA: 0x0018D670 File Offset: 0x0018B870
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

		// Token: 0x0600543B RID: 21563 RVA: 0x0018D73C File Offset: 0x0018B93C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleTeamSetAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003F42 RID: 16194
		private int _Result;

		// Token: 0x04003F43 RID: 16195
		private int _BattleId;

		// Token: 0x04003F44 RID: 16196
		private int _BattleType;

		// Token: 0x04003F45 RID: 16197
		private readonly List<int> _HeroIds = new List<int>();

		// Token: 0x04003F46 RID: 16198
		private IExtension extensionObject;

		// Token: 0x04003F47 RID: 16199
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003F48 RID: 16200
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003F49 RID: 16201
		private LuaFunction m_ctor_hotfix;
	}
}
