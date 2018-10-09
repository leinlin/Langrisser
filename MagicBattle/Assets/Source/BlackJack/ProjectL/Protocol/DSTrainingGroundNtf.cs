using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200072D RID: 1837
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "DSTrainingGroundNtf")]
	[Serializable]
	public class DSTrainingGroundNtf : IExtensible
	{
		// Token: 0x060060DF RID: 24799 RVA: 0x001B52C4 File Offset: 0x001B34C4
		public DSTrainingGroundNtf()
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

		// Token: 0x170018C0 RID: 6336
		// (get) Token: 0x060060E0 RID: 24800 RVA: 0x001B5338 File Offset: 0x001B3538
		// (set) Token: 0x060060E1 RID: 24801 RVA: 0x001B5340 File Offset: 0x001B3540
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

		// Token: 0x170018C1 RID: 6337
		// (get) Token: 0x060060E2 RID: 24802 RVA: 0x001B534C File Offset: 0x001B354C
		[ProtoMember(2, Name = "AvailableTechs", DataFormat = DataFormat.Default)]
		public List<ProTrainingTech> AvailableTechs
		{
			get
			{
				return this._AvailableTechs;
			}
		}

		// Token: 0x060060E3 RID: 24803 RVA: 0x001B5354 File Offset: 0x001B3554
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060060E4 RID: 24804 RVA: 0x001B5364 File Offset: 0x001B3564
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

		// Token: 0x060060E5 RID: 24805 RVA: 0x001B5430 File Offset: 0x001B3630
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DSTrainingGroundNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400488A RID: 18570
		private uint _Version;

		// Token: 0x0400488B RID: 18571
		private readonly List<ProTrainingTech> _AvailableTechs = new List<ProTrainingTech>();

		// Token: 0x0400488C RID: 18572
		private IExtension extensionObject;

		// Token: 0x0400488D RID: 18573
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400488E RID: 18574
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400488F RID: 18575
		private LuaFunction m_ctor_hotfix;
	}
}
