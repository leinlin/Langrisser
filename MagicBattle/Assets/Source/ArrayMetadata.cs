using System;

// Token: 0x02001091 RID: 4241
internal struct ArrayMetadata
{
	// Token: 0x17003E92 RID: 16018
	// (get) Token: 0x060156DC RID: 87772 RVA: 0x0056EC54 File Offset: 0x0056CE54
	// (set) Token: 0x060156DD RID: 87773 RVA: 0x0056EC74 File Offset: 0x0056CE74
	public Type ElementType
	{
		get
		{
			if (this.element_type == null)
			{
				return typeof(JsonData);
			}
			return this.element_type;
		}
		set
		{
			this.element_type = value;
		}
	}

	// Token: 0x17003E93 RID: 16019
	// (get) Token: 0x060156DE RID: 87774 RVA: 0x0056EC80 File Offset: 0x0056CE80
	// (set) Token: 0x060156DF RID: 87775 RVA: 0x0056EC88 File Offset: 0x0056CE88
	public bool IsArray
	{
		get
		{
			return this.is_array;
		}
		set
		{
			this.is_array = value;
		}
	}

	// Token: 0x17003E94 RID: 16020
	// (get) Token: 0x060156E0 RID: 87776 RVA: 0x0056EC94 File Offset: 0x0056CE94
	// (set) Token: 0x060156E1 RID: 87777 RVA: 0x0056EC9C File Offset: 0x0056CE9C
	public bool IsList
	{
		get
		{
			return this.is_list;
		}
		set
		{
			this.is_list = value;
		}
	}

	// Token: 0x0400BAB9 RID: 47801
	private Type element_type;

	// Token: 0x0400BABA RID: 47802
	private bool is_array;

	// Token: 0x0400BABB RID: 47803
	private bool is_list;
}
