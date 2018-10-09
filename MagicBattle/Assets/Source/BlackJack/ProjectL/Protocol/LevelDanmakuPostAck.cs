using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006B7 RID: 1719
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "LevelDanmakuPostAck")]
	[Serializable]
	public class LevelDanmakuPostAck : IExtensible
	{
		// Token: 0x06005D09 RID: 23817 RVA: 0x001A7764 File Offset: 0x001A5964
		public LevelDanmakuPostAck()
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

		// Token: 0x170017A5 RID: 6053
		// (get) Token: 0x06005D0A RID: 23818 RVA: 0x001A77CC File Offset: 0x001A59CC
		// (set) Token: 0x06005D0B RID: 23819 RVA: 0x001A77D4 File Offset: 0x001A59D4
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

		// Token: 0x06005D0C RID: 23820 RVA: 0x001A77E0 File Offset: 0x001A59E0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005D0D RID: 23821 RVA: 0x001A77F0 File Offset: 0x001A59F0
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

		// Token: 0x06005D0E RID: 23822 RVA: 0x001A78BC File Offset: 0x001A5ABC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(LevelDanmakuPostAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004597 RID: 17815
		private int _Result;

		// Token: 0x04004598 RID: 17816
		private IExtension extensionObject;

		// Token: 0x04004599 RID: 17817
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400459A RID: 17818
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400459B RID: 17819
		private LuaFunction m_ctor_hotfix;
	}
}
