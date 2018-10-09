using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200071D RID: 1821
	[ProtoContract(Name = "DSMailNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class DSMailNtf : IExtensible
	{
		// Token: 0x0600605A RID: 24666 RVA: 0x001B3490 File Offset: 0x001B1690
		public DSMailNtf()
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

		// Token: 0x17001893 RID: 6291
		// (get) Token: 0x0600605B RID: 24667 RVA: 0x001B34F8 File Offset: 0x001B16F8
		// (set) Token: 0x0600605C RID: 24668 RVA: 0x001B3500 File Offset: 0x001B1700
		[ProtoMember(1, IsRequired = true, Name = "Version", DataFormat = DataFormat.TwosComplement)]
		public uint Version
		{
			get
			{
				return this._Version;
			}
			set
			{
				this._Version = value;
			}
		}

		// Token: 0x17001894 RID: 6292
		// (get) Token: 0x0600605D RID: 24669 RVA: 0x001B350C File Offset: 0x001B170C
		// (set) Token: 0x0600605E RID: 24670 RVA: 0x001B3514 File Offset: 0x001B1714
		[ProtoMember(2, IsRequired = true, Name = "UnreadMailNums", DataFormat = DataFormat.TwosComplement)]
		public int UnreadMailNums
		{
			get
			{
				return this._UnreadMailNums;
			}
			set
			{
				this._UnreadMailNums = value;
			}
		}

		// Token: 0x0600605F RID: 24671 RVA: 0x001B3520 File Offset: 0x001B1720
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006060 RID: 24672 RVA: 0x001B3530 File Offset: 0x001B1730
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

		// Token: 0x06006061 RID: 24673 RVA: 0x001B35FC File Offset: 0x001B17FC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DSMailNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400481D RID: 18461
		private uint _Version;

		// Token: 0x0400481E RID: 18462
		private int _UnreadMailNums;

		// Token: 0x0400481F RID: 18463
		private IExtension extensionObject;

		// Token: 0x04004820 RID: 18464
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004821 RID: 18465
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004822 RID: 18466
		private LuaFunction m_ctor_hotfix;
	}
}
