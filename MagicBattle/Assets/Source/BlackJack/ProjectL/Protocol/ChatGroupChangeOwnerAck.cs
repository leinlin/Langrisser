using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200061B RID: 1563
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ChatGroupChangeOwnerAck")]
	[Serializable]
	public class ChatGroupChangeOwnerAck : IExtensible
	{
		// Token: 0x06005622 RID: 22050 RVA: 0x001941F0 File Offset: 0x001923F0
		public ChatGroupChangeOwnerAck()
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

		// Token: 0x17001539 RID: 5433
		// (get) Token: 0x06005623 RID: 22051 RVA: 0x00194258 File Offset: 0x00192458
		// (set) Token: 0x06005624 RID: 22052 RVA: 0x00194260 File Offset: 0x00192460
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

		// Token: 0x06005625 RID: 22053 RVA: 0x0019426C File Offset: 0x0019246C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005626 RID: 22054 RVA: 0x0019427C File Offset: 0x0019247C
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

		// Token: 0x06005627 RID: 22055 RVA: 0x00194348 File Offset: 0x00192548
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ChatGroupChangeOwnerAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040040BB RID: 16571
		private int _Result;

		// Token: 0x040040BC RID: 16572
		private IExtension extensionObject;

		// Token: 0x040040BD RID: 16573
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040040BE RID: 16574
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040040BF RID: 16575
		private LuaFunction m_ctor_hotfix;
	}
}
