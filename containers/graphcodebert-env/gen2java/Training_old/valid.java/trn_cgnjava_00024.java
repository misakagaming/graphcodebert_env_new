package com.j2cg.train;

import com.j2cg.base.CTCoolGenCore;

public class CYY1S011_TRAIN002 extends CTCoolGenCore {

	protected g_context dont_change_text m_LocalEntity001;
	protected iyy1_component m_LocalEntity002;

	
	@Override
	public void initialize(Object... inputs) {
	}
	
	@Override
	public void execute(Object...outputs) {
		m_LocalEntity001.text_150 = m_LocalEntity002.send_command;
	}
}