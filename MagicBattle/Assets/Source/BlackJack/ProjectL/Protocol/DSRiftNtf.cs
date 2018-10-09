using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200071B RID: 1819
	[ProtoContract(Name = "DSRiftNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class DSRiftNtf : IExtensible
	{
		// Token: 0x06006040 RID: 24640 RVA: 0x001B3064 File Offset: 0x001B1264
		public DSRiftNtf()
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

		// Token: 0x17001888 RID: 6280
		// (get) Token: 0x06006041 RID: 24641 RVA: 0x001B30E0 File Offset: 0x001B12E0
		// (set) Token: 0x06006042 RID: 24642 RVA: 0x001B30E8 File Offset: 0x001B12E8
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

		// Token: 0x17001889 RID: 6281
		// (get) Token: 0x06006043 RID: 24643 RVA: 0x001B30F4 File Offset: 0x001B12F4
		[ProtoMember(2, Name = "AchievementRelationIds", DataFormat = DataFormat.TwosComplement)]
		public List<int> AchievementRelationIds
		{
			get
			{
				return this._AchievementRelationIds;
			}
		}

		// Token: 0x1700188A RID: 6282
		// (get) Token: 0x06006044 RID: 24644 RVA: 0x001B30FC File Offset: 0x001B12FC
		[ProtoMember(3, Name = "RiftChapters", DataFormat = DataFormat.Default)]
		public List<ProRiftChapter> RiftChapters
		{
			get
			{
				return this._RiftChapters;
			}
		}

		// Token: 0x06006045 RID: 24645 RVA: 0x001B3104 File Offset: 0x001B1304
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006046 RID: 24646 RVA: 0x001B3114 File Offset: 0x001B1314
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

		// Token: 0x06006047 RID: 24647 RVA: 0x001B31E0 File Offset: 0x001B13E0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DSRiftNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400480A RID: 18442
		private uint _Version;

		// Token: 0x0400480B RID: 18443
		private readonly List<int> _AchievementRelationIds = new List<int>();

		// Token: 0x0400480C RID: 18444
		private readonly List<ProRiftChapter> _RiftChapters = new List<ProRiftChapter>();

		// Token: 0x0400480D RID: 18445
		private IExtension extensionObject;

		// Token: 0x0400480E RID: 18446
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400480F RID: 18447
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004810 RID: 18448
		private LuaFunction m_ctor_hotfix;
	}
}
