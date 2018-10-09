using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006F6 RID: 1782
	[ProtoContract(Name = "HeadPortraitSetAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class HeadPortraitSetAck : IExtensible
	{
		// Token: 0x06005F09 RID: 24329 RVA: 0x001AEBD4 File Offset: 0x001ACDD4
		public HeadPortraitSetAck()
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

		// Token: 0x17001832 RID: 6194
		// (get) Token: 0x06005F0A RID: 24330 RVA: 0x001AEC3C File Offset: 0x001ACE3C
		// (set) Token: 0x06005F0B RID: 24331 RVA: 0x001AEC44 File Offset: 0x001ACE44
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

		// Token: 0x17001833 RID: 6195
		// (get) Token: 0x06005F0C RID: 24332 RVA: 0x001AEC50 File Offset: 0x001ACE50
		// (set) Token: 0x06005F0D RID: 24333 RVA: 0x001AEC58 File Offset: 0x001ACE58
		[ProtoMember(2, IsRequired = true, Name = "HeadPortrait", DataFormat = DataFormat.TwosComplement)]
		public int HeadPortrait
		{
			get
			{
				return this._HeadPortrait;
			}
			set
			{
				this._HeadPortrait = value;
			}
		}

		// Token: 0x06005F0E RID: 24334 RVA: 0x001AEC64 File Offset: 0x001ACE64
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005F0F RID: 24335 RVA: 0x001AEC74 File Offset: 0x001ACE74
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

		// Token: 0x06005F10 RID: 24336 RVA: 0x001AED40 File Offset: 0x001ACF40
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeadPortraitSetAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004720 RID: 18208
		private int _Result;

		// Token: 0x04004721 RID: 18209
		private int _HeadPortrait;

		// Token: 0x04004722 RID: 18210
		private IExtension extensionObject;

		// Token: 0x04004723 RID: 18211
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004724 RID: 18212
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004725 RID: 18213
		private LuaFunction m_ctor_hotfix;
	}
}
