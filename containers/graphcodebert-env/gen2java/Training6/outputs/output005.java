public class DYYY0211_TRAIN012 extends CTCoolGenCore {
@Override
public void initialize(Object... inputs) {
setDBConnection(inputs);
}

@Override
public void execute(Object... outputs) {

dont_change_return_codes m_LocalEntity001 = new dont_change_return_codes();
dont_change_reason_codes m_LocalEntity002 = new dont_change_reason_codes();

child m_Output01 = (child) outputs[0];
error_iyy1_component m_Output02 = (error_iyy1_component) outputs[1];

try {
CTDBEntityQuery query = new CTDBEntityQuery(m_DBConnection, parent.class.getName());

child m_Record = new child();
m_Record.cinstance_id = m_InputEntity002.cinstance