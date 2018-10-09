using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000641 RID: 1601
	[ProtoContract(Name = "ProHeroJob")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProHeroJob : IExtensible
	{
		// Token: 0x0600579C RID: 22428 RVA: 0x00198AF8 File Offset: 0x00196CF8
		public ProHeroJob()
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

		// Token: 0x170015B0 RID: 5552
		// (get) Token: 0x0600579D RID: 22429 RVA: 0x00198B6C File Offset: 0x00196D6C
		// (set) Token: 0x0600579E RID: 22430 RVA: 0x00198B74 File Offset: 0x00196D74
		[ProtoMember(1, IsRequired = true, Name = "JobRelatedId", DataFormat = DataFormat.TwosComplement)]
		public int JobRelatedId
		{
			get
			{
				return this._JobRelatedId;
			}
			set
			{
				this._JobRelatedId = value;
			}
		}

		// Token: 0x170015B1 RID: 5553
		// (get) Token: 0x0600579F RID: 22431 RVA: 0x00198B80 File Offset: 0x00196D80
		// (set) Token: 0x060057A0 RID: 22432 RVA: 0x00198B88 File Offset: 0x00196D88
		[ProtoMember(2, IsRequired = true, Name = "JobLevel", DataFormat = DataFormat.TwosComplement)]
		public int JobLevel
		{
			get
			{
				return this._JobLevel;
			}
			set
			{
				this._JobLevel = value;
			}
		}

		// Token: 0x170015B2 RID: 5554
		// (get) Token: 0x060057A1 RID: 22433 RVA: 0x00198B94 File Offset: 0x00196D94
		// (set) Token: 0x060057A2 RID: 22434 RVA: 0x00198B9C File Offset: 0x00196D9C
		[ProtoMember(3, IsRequired = true, Name = "Mast", DataFormat = DataFormat.TwosComplement)]
		public int Mast
		{
			get
			{
				return this._Mast;
			}
			set
			{
				this._Mast = value;
			}
		}

		// Token: 0x170015B3 RID: 5555
		// (get) Token: 0x060057A3 RID: 22435 RVA: 0x00198BA8 File Offset: 0x00196DA8
		[ProtoMember(4, Name = "Achievements", DataFormat = DataFormat.TwosComplement)]
		public List<int> Achievements
		{
			get
			{
				return this._Achievements;
			}
		}

		// Token: 0x170015B4 RID: 5556
		// (get) Token: 0x060057A4 RID: 22436 RVA: 0x00198BB0 File Offset: 0x00196DB0
		// (set) Token: 0x060057A5 RID: 22437 RVA: 0x00198BB8 File Offset: 0x00196DB8
		[ProtoMember(5, IsRequired = true, Name = "ModelSkinId", DataFormat = DataFormat.TwosComplement)]
		public int ModelSkinId
		{
			get
			{
				return this._ModelSkinId;
			}
			set
			{
				this._ModelSkinId = value;
			}
		}

		// Token: 0x060057A6 RID: 22438 RVA: 0x00198BC4 File Offset: 0x00196DC4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060057A7 RID: 22439 RVA: 0x00198BD4 File Offset: 0x00196DD4
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

		// Token: 0x060057A8 RID: 22440 RVA: 0x00198CA0 File Offset: 0x00196EA0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProHeroJob));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040041CA RID: 16842
		private int _JobRelatedId;

		// Token: 0x040041CB RID: 16843
		private int _JobLevel;

		// Token: 0x040041CC RID: 16844
		private int _Mast;

		// Token: 0x040041CD RID: 16845
		private readonly List<int> _Achievements = new List<int>();

		// Token: 0x040041CE RID: 16846
		private int _ModelSkinId;

		// Token: 0x040041CF RID: 16847
		private IExtension extensionObject;

		// Token: 0x040041D0 RID: 16848
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040041D1 RID: 16849
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040041D2 RID: 16850
		private LuaFunction m_ctor_hotfix;
	}
}
