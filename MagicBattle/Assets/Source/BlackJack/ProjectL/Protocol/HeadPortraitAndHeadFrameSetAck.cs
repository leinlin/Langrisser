using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000707 RID: 1799
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "HeadPortraitAndHeadFrameSetAck")]
	[Serializable]
	public class HeadPortraitAndHeadFrameSetAck : IExtensible
	{
		// Token: 0x06005F79 RID: 24441 RVA: 0x001B0A0C File Offset: 0x001AEC0C
		public HeadPortraitAndHeadFrameSetAck()
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

		// Token: 0x17001849 RID: 6217
		// (get) Token: 0x06005F7A RID: 24442 RVA: 0x001B0A74 File Offset: 0x001AEC74
		// (set) Token: 0x06005F7B RID: 24443 RVA: 0x001B0A7C File Offset: 0x001AEC7C
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

		// Token: 0x1700184A RID: 6218
		// (get) Token: 0x06005F7C RID: 24444 RVA: 0x001B0A88 File Offset: 0x001AEC88
		// (set) Token: 0x06005F7D RID: 24445 RVA: 0x001B0A90 File Offset: 0x001AEC90
		[ProtoMember(2, IsRequired = true, Name = "HeadPortraitId", DataFormat = DataFormat.TwosComplement)]
		public int HeadPortraitId
		{
			get
			{
				return this._HeadPortraitId;
			}
			set
			{
				this._HeadPortraitId = value;
			}
		}

		// Token: 0x1700184B RID: 6219
		// (get) Token: 0x06005F7E RID: 24446 RVA: 0x001B0A9C File Offset: 0x001AEC9C
		// (set) Token: 0x06005F7F RID: 24447 RVA: 0x001B0AA4 File Offset: 0x001AECA4
		[ProtoMember(3, IsRequired = true, Name = "HeadFrameId", DataFormat = DataFormat.TwosComplement)]
		public int HeadFrameId
		{
			get
			{
				return this._HeadFrameId;
			}
			set
			{
				this._HeadFrameId = value;
			}
		}

		// Token: 0x06005F80 RID: 24448 RVA: 0x001B0AB0 File Offset: 0x001AECB0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005F81 RID: 24449 RVA: 0x001B0AC0 File Offset: 0x001AECC0
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

		// Token: 0x06005F82 RID: 24450 RVA: 0x001B0B8C File Offset: 0x001AED8C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeadPortraitAndHeadFrameSetAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400477B RID: 18299
		private int _Result;

		// Token: 0x0400477C RID: 18300
		private int _HeadPortraitId;

		// Token: 0x0400477D RID: 18301
		private int _HeadFrameId;

		// Token: 0x0400477E RID: 18302
		private IExtension extensionObject;

		// Token: 0x0400477F RID: 18303
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004780 RID: 18304
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004781 RID: 18305
		private LuaFunction m_ctor_hotfix;
	}
}
