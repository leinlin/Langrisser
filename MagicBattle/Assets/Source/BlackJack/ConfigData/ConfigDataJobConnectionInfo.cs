using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000258 RID: 600
	[HotFix(true, m_isCtorOnly = true)]
	[CustomLuaClass]
	[ProtoContract(Name = "ConfigDataJobConnectionInfo")]
	[Serializable]
	public class ConfigDataJobConnectionInfo : IExtensible
	{
		// Token: 0x060025B0 RID: 9648 RVA: 0x000A94C0 File Offset: 0x000A76C0
		public ConfigDataJobConnectionInfo()
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

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x060025B1 RID: 9649 RVA: 0x000A9568 File Offset: 0x000A7768
		// (set) Token: 0x060025B2 RID: 9650 RVA: 0x000A9570 File Offset: 0x000A7770
		[ProtoMember(2, IsRequired = true, Name = "ID", DataFormat = DataFormat.TwosComplement)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				this._ID = value;
			}
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x060025B3 RID: 9651 RVA: 0x000A957C File Offset: 0x000A777C
		// (set) Token: 0x060025B4 RID: 9652 RVA: 0x000A9584 File Offset: 0x000A7784
		[ProtoMember(3, IsRequired = true, Name = "Desc", DataFormat = DataFormat.Default)]
		public string Desc
		{
			get
			{
				return this._Desc;
			}
			set
			{
				this._Desc = value;
			}
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x060025B5 RID: 9653 RVA: 0x000A9590 File Offset: 0x000A7790
		// (set) Token: 0x060025B6 RID: 9654 RVA: 0x000A9598 File Offset: 0x000A7798
		[ProtoMember(4, IsRequired = true, Name = "DescStrKey", DataFormat = DataFormat.Default)]
		public string DescStrKey
		{
			get
			{
				return this._DescStrKey;
			}
			set
			{
				this._DescStrKey = value;
			}
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x060025B7 RID: 9655 RVA: 0x000A95A4 File Offset: 0x000A77A4
		// (set) Token: 0x060025B8 RID: 9656 RVA: 0x000A95AC File Offset: 0x000A77AC
		[ProtoMember(5, IsRequired = true, Name = "Name_Eng", DataFormat = DataFormat.Default)]
		public string Name_Eng
		{
			get
			{
				return this._Name_Eng;
			}
			set
			{
				this._Name_Eng = value;
			}
		}

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x060025B9 RID: 9657 RVA: 0x000A95B8 File Offset: 0x000A77B8
		// (set) Token: 0x060025BA RID: 9658 RVA: 0x000A95C0 File Offset: 0x000A77C0
		[ProtoMember(6, IsRequired = true, Name = "Job_ID", DataFormat = DataFormat.TwosComplement)]
		public int Job_ID
		{
			get
			{
				return this._Job_ID;
			}
			set
			{
				this._Job_ID = value;
			}
		}

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x060025BB RID: 9659 RVA: 0x000A95CC File Offset: 0x000A77CC
		[ProtoMember(7, Name = "JobLevels_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> JobLevels_ID
		{
			get
			{
				return this._JobLevels_ID;
			}
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x060025BC RID: 9660 RVA: 0x000A95D4 File Offset: 0x000A77D4
		[ProtoMember(8, Name = "TalentSkill_IDs", DataFormat = DataFormat.TwosComplement)]
		public List<int> TalentSkill_IDs
		{
			get
			{
				return this._TalentSkill_IDs;
			}
		}

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x060025BD RID: 9661 RVA: 0x000A95DC File Offset: 0x000A77DC
		// (set) Token: 0x060025BE RID: 9662 RVA: 0x000A95E4 File Offset: 0x000A77E4
		[ProtoMember(9, IsRequired = true, Name = "UISort", DataFormat = DataFormat.TwosComplement)]
		public int UISort
		{
			get
			{
				return this._UISort;
			}
			set
			{
				this._UISort = value;
			}
		}

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x060025BF RID: 9663 RVA: 0x000A95F0 File Offset: 0x000A77F0
		// (set) Token: 0x060025C0 RID: 9664 RVA: 0x000A95F8 File Offset: 0x000A77F8
		[ProtoMember(10, IsRequired = true, Name = "PropertyRating", DataFormat = DataFormat.Default)]
		public string PropertyRating
		{
			get
			{
				return this._PropertyRating;
			}
			set
			{
				this._PropertyRating = value;
			}
		}

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x060025C1 RID: 9665 RVA: 0x000A9604 File Offset: 0x000A7804
		// (set) Token: 0x060025C2 RID: 9666 RVA: 0x000A960C File Offset: 0x000A780C
		[ProtoMember(11, IsRequired = true, Name = "IsRecommend", DataFormat = DataFormat.Default)]
		public bool IsRecommend
		{
			get
			{
				return this._IsRecommend;
			}
			set
			{
				this._IsRecommend = value;
			}
		}

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x060025C3 RID: 9667 RVA: 0x000A9618 File Offset: 0x000A7818
		// (set) Token: 0x060025C4 RID: 9668 RVA: 0x000A9620 File Offset: 0x000A7820
		[ProtoMember(12, IsRequired = true, Name = "Model", DataFormat = DataFormat.Default)]
		public string Model
		{
			get
			{
				return this._Model;
			}
			set
			{
				this._Model = value;
			}
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x060025C5 RID: 9669 RVA: 0x000A962C File Offset: 0x000A782C
		// (set) Token: 0x060025C6 RID: 9670 RVA: 0x000A9634 File Offset: 0x000A7834
		[ProtoMember(13, IsRequired = true, Name = "CombatModel", DataFormat = DataFormat.Default)]
		public string CombatModel
		{
			get
			{
				return this._CombatModel;
			}
			set
			{
				this._CombatModel = value;
			}
		}

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x060025C7 RID: 9671 RVA: 0x000A9640 File Offset: 0x000A7840
		[ProtoMember(14, Name = "ReplaceAnims", DataFormat = DataFormat.Default)]
		public List<ReplaceAnim> ReplaceAnims
		{
			get
			{
				return this._ReplaceAnims;
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x060025C8 RID: 9672 RVA: 0x000A9648 File Offset: 0x000A7848
		// (set) Token: 0x060025C9 RID: 9673 RVA: 0x000A9650 File Offset: 0x000A7850
		[ProtoMember(15, IsRequired = true, Name = "ModelScale", DataFormat = DataFormat.TwosComplement)]
		public int ModelScale
		{
			get
			{
				return this._ModelScale;
			}
			set
			{
				this._ModelScale = value;
			}
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x060025CA RID: 9674 RVA: 0x000A965C File Offset: 0x000A785C
		// (set) Token: 0x060025CB RID: 9675 RVA: 0x000A9664 File Offset: 0x000A7864
		[ProtoMember(16, IsRequired = true, Name = "BF_ModelScale", DataFormat = DataFormat.TwosComplement)]
		public int BF_ModelScale
		{
			get
			{
				return this._BF_ModelScale;
			}
			set
			{
				this._BF_ModelScale = value;
			}
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x060025CC RID: 9676 RVA: 0x000A9670 File Offset: 0x000A7870
		// (set) Token: 0x060025CD RID: 9677 RVA: 0x000A9678 File Offset: 0x000A7878
		[ProtoMember(17, IsRequired = true, Name = "UI_ModelScale", DataFormat = DataFormat.TwosComplement)]
		public int UI_ModelScale
		{
			get
			{
				return this._UI_ModelScale;
			}
			set
			{
				this._UI_ModelScale = value;
			}
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x060025CE RID: 9678 RVA: 0x000A9684 File Offset: 0x000A7884
		// (set) Token: 0x060025CF RID: 9679 RVA: 0x000A968C File Offset: 0x000A788C
		[ProtoMember(18, IsRequired = true, Name = "UI_ModelOffsetX", DataFormat = DataFormat.TwosComplement)]
		public int UI_ModelOffsetX
		{
			get
			{
				return this._UI_ModelOffsetX;
			}
			set
			{
				this._UI_ModelOffsetX = value;
			}
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x060025D0 RID: 9680 RVA: 0x000A9698 File Offset: 0x000A7898
		// (set) Token: 0x060025D1 RID: 9681 RVA: 0x000A96A0 File Offset: 0x000A78A0
		[ProtoMember(19, IsRequired = true, Name = "UI_ModelOffsetY", DataFormat = DataFormat.TwosComplement)]
		public int UI_ModelOffsetY
		{
			get
			{
				return this._UI_ModelOffsetY;
			}
			set
			{
				this._UI_ModelOffsetY = value;
			}
		}

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x060025D2 RID: 9682 RVA: 0x000A96AC File Offset: 0x000A78AC
		// (set) Token: 0x060025D3 RID: 9683 RVA: 0x000A96B4 File Offset: 0x000A78B4
		[ProtoMember(20, IsRequired = true, Name = "Radius", DataFormat = DataFormat.TwosComplement)]
		public int Radius
		{
			get
			{
				return this._Radius;
			}
			set
			{
				this._Radius = value;
			}
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x060025D4 RID: 9684 RVA: 0x000A96C0 File Offset: 0x000A78C0
		// (set) Token: 0x060025D5 RID: 9685 RVA: 0x000A96C8 File Offset: 0x000A78C8
		[ProtoMember(21, IsRequired = true, Name = "Height", DataFormat = DataFormat.TwosComplement)]
		public int Height
		{
			get
			{
				return this._Height;
			}
			set
			{
				this._Height = value;
			}
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x060025D6 RID: 9686 RVA: 0x000A96D4 File Offset: 0x000A78D4
		// (set) Token: 0x060025D7 RID: 9687 RVA: 0x000A96DC File Offset: 0x000A78DC
		[ProtoMember(22, IsRequired = true, Name = "FootHeight", DataFormat = DataFormat.TwosComplement)]
		public int FootHeight
		{
			get
			{
				return this._FootHeight;
			}
			set
			{
				this._FootHeight = value;
			}
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x060025D8 RID: 9688 RVA: 0x000A96E8 File Offset: 0x000A78E8
		[ProtoMember(23, Name = "PreJobConnectionList", DataFormat = DataFormat.TwosComplement)]
		public List<int> PreJobConnectionList
		{
			get
			{
				return this._PreJobConnectionList;
			}
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x060025D9 RID: 9689 RVA: 0x000A96F0 File Offset: 0x000A78F0
		[ProtoMember(24, Name = "JobUnlockConditioList", DataFormat = DataFormat.TwosComplement)]
		public List<int> JobUnlockConditioList
		{
			get
			{
				return this._JobUnlockConditioList;
			}
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x060025DA RID: 9690 RVA: 0x000A96F8 File Offset: 0x000A78F8
		// (set) Token: 0x060025DB RID: 9691 RVA: 0x000A9700 File Offset: 0x000A7900
		[ProtoMember(25, IsRequired = true, Name = "IsJobOpen", DataFormat = DataFormat.Default)]
		public bool IsJobOpen
		{
			get
			{
				return this._IsJobOpen;
			}
			set
			{
				this._IsJobOpen = value;
			}
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x060025DC RID: 9692 RVA: 0x000A970C File Offset: 0x000A790C
		[ProtoMember(26, Name = "Skins_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> Skins_ID
		{
			get
			{
				return this._Skins_ID;
			}
		}

		// Token: 0x060025DD RID: 9693 RVA: 0x000A9714 File Offset: 0x000A7914
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060025DE RID: 9694 RVA: 0x000A9724 File Offset: 0x000A7924
		public ConfigDataSkillInfo GetTalentSkillInfo(int heroStar)
		{
			if (this.m_talentSkillInfos.Count == 1)
			{
				return this.m_talentSkillInfos[0];
			}
			if (heroStar > this.m_talentSkillInfos.Count)
			{
				return null;
			}
			return this.m_talentSkillInfos[heroStar - 1];
		}

		// Token: 0x060025DF RID: 9695 RVA: 0x000A9770 File Offset: 0x000A7970
		public bool IsJobLevelMax(int jobLevel)
		{
			return jobLevel >= this.JobLevels_ID.Count - 1;
		}

		// Token: 0x060025E0 RID: 9696 RVA: 0x000A9788 File Offset: 0x000A7988
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

		// Token: 0x060025E1 RID: 9697 RVA: 0x000A9854 File Offset: 0x000A7A54
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataJobConnectionInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400170B RID: 5899
		private int _ID;

		// Token: 0x0400170C RID: 5900
		private string _Desc;

		// Token: 0x0400170D RID: 5901
		private string _DescStrKey;

		// Token: 0x0400170E RID: 5902
		private string _Name_Eng;

		// Token: 0x0400170F RID: 5903
		private int _Job_ID;

		// Token: 0x04001710 RID: 5904
		private readonly List<int> _JobLevels_ID = new List<int>();

		// Token: 0x04001711 RID: 5905
		private readonly List<int> _TalentSkill_IDs = new List<int>();

		// Token: 0x04001712 RID: 5906
		private int _UISort;

		// Token: 0x04001713 RID: 5907
		private string _PropertyRating;

		// Token: 0x04001714 RID: 5908
		private bool _IsRecommend;

		// Token: 0x04001715 RID: 5909
		private string _Model;

		// Token: 0x04001716 RID: 5910
		private string _CombatModel;

		// Token: 0x04001717 RID: 5911
		private readonly List<ReplaceAnim> _ReplaceAnims = new List<ReplaceAnim>();

		// Token: 0x04001718 RID: 5912
		private int _ModelScale;

		// Token: 0x04001719 RID: 5913
		private int _BF_ModelScale;

		// Token: 0x0400171A RID: 5914
		private int _UI_ModelScale;

		// Token: 0x0400171B RID: 5915
		private int _UI_ModelOffsetX;

		// Token: 0x0400171C RID: 5916
		private int _UI_ModelOffsetY;

		// Token: 0x0400171D RID: 5917
		private int _Radius;

		// Token: 0x0400171E RID: 5918
		private int _Height;

		// Token: 0x0400171F RID: 5919
		private int _FootHeight;

		// Token: 0x04001720 RID: 5920
		private readonly List<int> _PreJobConnectionList = new List<int>();

		// Token: 0x04001721 RID: 5921
		private readonly List<int> _JobUnlockConditioList = new List<int>();

		// Token: 0x04001722 RID: 5922
		private bool _IsJobOpen;

		// Token: 0x04001723 RID: 5923
		private readonly List<int> _Skins_ID = new List<int>();

		// Token: 0x04001724 RID: 5924
		private IExtension extensionObject;

		// Token: 0x04001725 RID: 5925
		public ConfigDataJobInfo m_jobInfo;

		// Token: 0x04001726 RID: 5926
		public ConfigDataJobLevelInfo[] m_jobLevelInfos;

		// Token: 0x04001727 RID: 5927
		public List<ConfigDataJobUnlockConditionInfo> m_unlockConditions;

		// Token: 0x04001728 RID: 5928
		public List<ConfigDataJobConnectionInfo> m_preJobConnectionInfos;

		// Token: 0x04001729 RID: 5929
		public List<ConfigDataSkillInfo> m_talentSkillInfos;

		// Token: 0x0400172A RID: 5930
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400172B RID: 5931
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400172C RID: 5932
		private LuaFunction m_ctor_hotfix;
	}
}
