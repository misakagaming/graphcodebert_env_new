package com.j2cg.train;

import com.j2cg.base.CTCoolGenCore;

public class CYY1S081_TRAIN006 extends CTCoolGenCore {

	protected imp_error_iyy1_component m_LocalEntity001;

	@Override
	public void initialize(Object... inputs) {
	}

	@Override
	public void execute(Object... outputs) {
		imp_error_iyy1_component m_Output01 = (imp_error_iyy1_component) outputs[1];
		
		moveMember(m_LocalEntity001, m_Output01);
	}

}