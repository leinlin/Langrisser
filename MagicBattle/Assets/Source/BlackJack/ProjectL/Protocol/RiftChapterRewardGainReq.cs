using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200081E RID: 2078
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "RiftChapterRewardGainReq")]
	[Serializable]
	public class RiftChapterRewardGainReq : IExtensible
	{
		// Token: 0x060068BD RID: 26813 RVA: 0x001D84EC File Offset: 0x001D66EC
		public RiftChapterRewardGainReq()
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

		// Token: 0x17001AE9 RID: 6889
		// (get) Token: 0x060068BE RID: 26814 RVA: 0x001D8554 File Offset: 0x001D6754
		// (set) Token: 0x060068BF RID: 26815 RVA: 0x001D855C File Offset: 0x001D675C
		[ProtoMember(1, IsRequired = true, Name = "ChapterId", DataFormat = DataFormat.TwosComplement)]
		public int ChapterId
		{
			get
			{
				return this._ChapterId;
			}
			set
			{
				this._ChapterId = value;
			}
		}

		// Token: 0x17001AEA RID: 6890
		// (get) Token: 0x060068C0 RID: 26816 RVA: 0x001D8568 File Offset: 0x001D6768
		// (set) Token: 0x060068C1 RID: 26817 RVA: 0x001D8570 File Offset: 0x001D6770
		[ProtoMember(2, IsRequired = true, Name = "Index", DataFormat = DataFormat.TwosComplement)]
		public int Index
		{
			get
			{
				return this._Index;
			}
			set
			{
				this._Index = value;
			}
		}

		// Token: 0x060068C2 RID: 26818 RVA: 0x001D857C File Offset: 0x001D677C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060068C3 RID: 26819 RVA: 0x001D858C File Offset: 0x001D678C
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

		// Token: 0x060068C4 RID: 26820 RVA: 0x001D8658 File Offset: 0x001D6858
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RiftChapterRewardGainReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040050B7 RID: 20663
		private int _ChapterId;

		// Token: 0x040050B8 RID: 20664
		private int _Index;

		// Token: 0x040050B9 RID: 20665
		private IExtension extensionObject;

		// Token: 0x040050BA RID: 20666
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040050BB RID: 20667
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040050BC RID: 20668
		private LuaFunction m_ctor_hotfix;
	}
}
