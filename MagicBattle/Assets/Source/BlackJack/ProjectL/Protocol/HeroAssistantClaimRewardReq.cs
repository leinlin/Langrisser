using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000797 RID: 1943
	[ProtoContract(Name = "HeroAssistantClaimRewardReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class HeroAssistantClaimRewardReq : IExtensible
	{
		// Token: 0x0600640C RID: 25612 RVA: 0x001C142C File Offset: 0x001BF62C
		public HeroAssistantClaimRewardReq()
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

		// Token: 0x1700198E RID: 6542
		// (get) Token: 0x0600640D RID: 25613 RVA: 0x001C1494 File Offset: 0x001BF694
		// (set) Token: 0x0600640E RID: 25614 RVA: 0x001C149C File Offset: 0x001BF69C
		[ProtoMember(1, IsRequired = true, Name = "TaskId", DataFormat = DataFormat.TwosComplement)]
		public int TaskId
		{
			get
			{
				return this._TaskId;
			}
			set
			{
				this._TaskId = value;
			}
		}

		// Token: 0x1700198F RID: 6543
		// (get) Token: 0x0600640F RID: 25615 RVA: 0x001C14A8 File Offset: 0x001BF6A8
		// (set) Token: 0x06006410 RID: 25616 RVA: 0x001C14B0 File Offset: 0x001BF6B0
		[ProtoMember(2, IsRequired = true, Name = "Slot", DataFormat = DataFormat.TwosComplement)]
		public int Slot
		{
			get
			{
				return this._Slot;
			}
			set
			{
				this._Slot = value;
			}
		}

		// Token: 0x06006411 RID: 25617 RVA: 0x001C14BC File Offset: 0x001BF6BC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006412 RID: 25618 RVA: 0x001C14CC File Offset: 0x001BF6CC
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

		// Token: 0x06006413 RID: 25619 RVA: 0x001C1598 File Offset: 0x001BF798
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroAssistantClaimRewardReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004B00 RID: 19200
		private int _TaskId;

		// Token: 0x04004B01 RID: 19201
		private int _Slot;

		// Token: 0x04004B02 RID: 19202
		private IExtension extensionObject;

		// Token: 0x04004B03 RID: 19203
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004B04 RID: 19204
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004B05 RID: 19205
		private LuaFunction m_ctor_hotfix;
	}
}
