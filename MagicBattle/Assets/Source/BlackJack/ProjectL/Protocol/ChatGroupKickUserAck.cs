using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000617 RID: 1559
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ChatGroupKickUserAck")]
	[Serializable]
	public class ChatGroupKickUserAck : IExtensible
	{
		// Token: 0x06005603 RID: 22019 RVA: 0x00193AA0 File Offset: 0x00191CA0
		public ChatGroupKickUserAck()
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

		// Token: 0x17001531 RID: 5425
		// (get) Token: 0x06005604 RID: 22020 RVA: 0x00193B08 File Offset: 0x00191D08
		// (set) Token: 0x06005605 RID: 22021 RVA: 0x00193B10 File Offset: 0x00191D10
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

		// Token: 0x06005606 RID: 22022 RVA: 0x00193B1C File Offset: 0x00191D1C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005607 RID: 22023 RVA: 0x00193B2C File Offset: 0x00191D2C
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

		// Token: 0x06005608 RID: 22024 RVA: 0x00193BF8 File Offset: 0x00191DF8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ChatGroupKickUserAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040040A3 RID: 16547
		private int _Result;

		// Token: 0x040040A4 RID: 16548
		private IExtension extensionObject;

		// Token: 0x040040A5 RID: 16549
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040040A6 RID: 16550
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040040A7 RID: 16551
		private LuaFunction m_ctor_hotfix;
	}
}
