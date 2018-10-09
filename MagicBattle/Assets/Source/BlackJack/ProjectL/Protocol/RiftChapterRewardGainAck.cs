using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200081F RID: 2079
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "RiftChapterRewardGainAck")]
	[Serializable]
	public class RiftChapterRewardGainAck : IExtensible
	{
		// Token: 0x060068C5 RID: 26821 RVA: 0x001D86C0 File Offset: 0x001D68C0
		public RiftChapterRewardGainAck()
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

		// Token: 0x17001AEB RID: 6891
		// (get) Token: 0x060068C6 RID: 26822 RVA: 0x001D8734 File Offset: 0x001D6934
		// (set) Token: 0x060068C7 RID: 26823 RVA: 0x001D873C File Offset: 0x001D693C
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

		// Token: 0x17001AEC RID: 6892
		// (get) Token: 0x060068C8 RID: 26824 RVA: 0x001D8748 File Offset: 0x001D6948
		// (set) Token: 0x060068C9 RID: 26825 RVA: 0x001D8750 File Offset: 0x001D6950
		[ProtoMember(2, IsRequired = true, Name = "ChapterId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001AED RID: 6893
		// (get) Token: 0x060068CA RID: 26826 RVA: 0x001D875C File Offset: 0x001D695C
		// (set) Token: 0x060068CB RID: 26827 RVA: 0x001D8764 File Offset: 0x001D6964
		[ProtoMember(3, IsRequired = true, Name = "Index", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001AEE RID: 6894
		// (get) Token: 0x060068CC RID: 26828 RVA: 0x001D8770 File Offset: 0x001D6970
		// (set) Token: 0x060068CD RID: 26829 RVA: 0x001D8778 File Offset: 0x001D6978
		[DefaultValue(null)]
		[ProtoMember(4, IsRequired = false, Name = "Ntf", DataFormat = DataFormat.Default)]
		public ProChangedGoodsNtf Ntf
		{
			get
			{
				return this._Ntf;
			}
			set
			{
				this._Ntf = value;
			}
		}

		// Token: 0x17001AEF RID: 6895
		// (get) Token: 0x060068CE RID: 26830 RVA: 0x001D8784 File Offset: 0x001D6984
		[ProtoMember(5, Name = "NormalRewards", DataFormat = DataFormat.Default)]
		public List<ProGoods> NormalRewards
		{
			get
			{
				return this._NormalRewards;
			}
		}

		// Token: 0x060068CF RID: 26831 RVA: 0x001D878C File Offset: 0x001D698C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060068D0 RID: 26832 RVA: 0x001D879C File Offset: 0x001D699C
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

		// Token: 0x060068D1 RID: 26833 RVA: 0x001D8868 File Offset: 0x001D6A68
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RiftChapterRewardGainAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040050BD RID: 20669
		private int _Result;

		// Token: 0x040050BE RID: 20670
		private int _ChapterId;

		// Token: 0x040050BF RID: 20671
		private int _Index;

		// Token: 0x040050C0 RID: 20672
		private ProChangedGoodsNtf _Ntf;

		// Token: 0x040050C1 RID: 20673
		private readonly List<ProGoods> _NormalRewards = new List<ProGoods>();

		// Token: 0x040050C2 RID: 20674
		private IExtension extensionObject;

		// Token: 0x040050C3 RID: 20675
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040050C4 RID: 20676
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040050C5 RID: 20677
		private LuaFunction m_ctor_hotfix;
	}
}
