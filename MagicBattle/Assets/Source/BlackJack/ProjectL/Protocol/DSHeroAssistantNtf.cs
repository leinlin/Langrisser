using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200072E RID: 1838
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "DSHeroAssistantNtf")]
	[Serializable]
	public class DSHeroAssistantNtf : IExtensible
	{
		// Token: 0x060060E6 RID: 24806 RVA: 0x001B5498 File Offset: 0x001B3698
		public DSHeroAssistantNtf()
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

		// Token: 0x170018C2 RID: 6338
		// (get) Token: 0x060060E7 RID: 24807 RVA: 0x001B550C File Offset: 0x001B370C
		// (set) Token: 0x060060E8 RID: 24808 RVA: 0x001B5514 File Offset: 0x001B3714
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

		// Token: 0x170018C3 RID: 6339
		// (get) Token: 0x060060E9 RID: 24809 RVA: 0x001B5520 File Offset: 0x001B3720
		[ProtoMember(2, Name = "Tasks", DataFormat = DataFormat.Default)]
		public List<ProHeroAssistantTask> Tasks
		{
			get
			{
				return this._Tasks;
			}
		}

		// Token: 0x060060EA RID: 24810 RVA: 0x001B5528 File Offset: 0x001B3728
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060060EB RID: 24811 RVA: 0x001B5538 File Offset: 0x001B3738
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

		// Token: 0x060060EC RID: 24812 RVA: 0x001B5604 File Offset: 0x001B3804
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DSHeroAssistantNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004890 RID: 18576
		private uint _Version;

		// Token: 0x04004891 RID: 18577
		private readonly List<ProHeroAssistantTask> _Tasks = new List<ProHeroAssistantTask>();

		// Token: 0x04004892 RID: 18578
		private IExtension extensionObject;

		// Token: 0x04004893 RID: 18579
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004894 RID: 18580
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004895 RID: 18581
		private LuaFunction m_ctor_hotfix;
	}
}
