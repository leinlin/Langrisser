using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005CD RID: 1485
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ArenaFlushOpponentsNtf")]
	[Serializable]
	public class ArenaFlushOpponentsNtf : IExtensible
	{
		// Token: 0x06005386 RID: 21382 RVA: 0x0018B064 File Offset: 0x00189264
		public ArenaFlushOpponentsNtf()
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

		// Token: 0x17001477 RID: 5239
		// (get) Token: 0x06005387 RID: 21383 RVA: 0x0018B0D8 File Offset: 0x001892D8
		[ProtoMember(1, Name = "Opponents", DataFormat = DataFormat.Default)]
		public List<ProArenaOpponent> Opponents
		{
			get
			{
				return this._Opponents;
			}
		}

		// Token: 0x17001478 RID: 5240
		// (get) Token: 0x06005388 RID: 21384 RVA: 0x0018B0E0 File Offset: 0x001892E0
		// (set) Token: 0x06005389 RID: 21385 RVA: 0x0018B0E8 File Offset: 0x001892E8
		[ProtoMember(2, IsRequired = true, Name = "NextFlushOpponentTime", DataFormat = DataFormat.TwosComplement)]
		public long NextFlushOpponentTime
		{
			get
			{
				return this._NextFlushOpponentTime;
			}
			set
			{
				this._NextFlushOpponentTime = value;
			}
		}

		// Token: 0x0600538A RID: 21386 RVA: 0x0018B0F4 File Offset: 0x001892F4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600538B RID: 21387 RVA: 0x0018B104 File Offset: 0x00189304
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

		// Token: 0x0600538C RID: 21388 RVA: 0x0018B1D0 File Offset: 0x001893D0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaFlushOpponentsNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003EC1 RID: 16065
		private readonly List<ProArenaOpponent> _Opponents = new List<ProArenaOpponent>();

		// Token: 0x04003EC2 RID: 16066
		private long _NextFlushOpponentTime;

		// Token: 0x04003EC3 RID: 16067
		private IExtension extensionObject;

		// Token: 0x04003EC4 RID: 16068
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003EC5 RID: 16069
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003EC6 RID: 16070
		private LuaFunction m_ctor_hotfix;
	}
}
