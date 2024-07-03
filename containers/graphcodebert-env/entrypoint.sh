#!/bin/bash
source /opt/python3/venv/base/bin/activate
echo "nice"
cd parser
bash build.sh
cd ..
source=java
target=cs
lr=1e-4
batch_size=32
beam_size=10
source_length=320
target_length=256
output_dir=saved_models/$source-$target/
train_file=train_file=ort/yyy.gensrc/CYY1A121.gensrc,ort/yyy.java/CYY1A121.java
dev_file=data/valid.java-cs.txt.$source,data/valid.java-cs.txt.$target
epochs=100
pretrained_model=microsoft/graphcodebert-base
python3 run.py --do_train --do_eval --model_type roberta --source_lang java --model_name_or_path microsoft/graphcodebert-base --tokenizer_name microsoft/graphcodebert-base --config_name microsoft/graphcodebert-base --train_filename data/train.java-cs.txt.java,data/train.java-cs.txt.cs --dev_filename data/valid.java-cs.txt.java,data/valid.java-cs.txt.cs --output_dir saved_models/java-cs --max_source_length 320 --max_target_length 256 --beam_size 10 --train_batch_size 32 --eval_batch_size 32 --learning_rate 1e-4 --num_train_epochs 100 2>&1 | tee "saved_models/java-cs/train.log"
batch_size=64
dev_file=data/valid.java-cs.txt.$source,data/valid.java-cs.txt.$target
test_file=data/test.java-cs.txt.$source,data/test.java-cs.txt.$target
load_model_path=$output_dir/checkpoint-best-bleu/pytorch_model.bin #checkpoint for test
python3 run.py \
--do_test \
--model_type roberta \
--source_lang $source \
--model_name_or_path $pretrained_model \
--tokenizer_name microsoft/graphcodebert-base \
--config_name microsoft/graphcodebert-base \
--load_model_path $load_model_path \
--dev_filename $dev_file \
--test_filename $test_file \
--output_dir $output_dir \
--max_source_length $source_length \
--max_target_length $target_length \
--beam_size $beam_size \
--eval_batch_size $batch_size 2>&1| tee $output_dir/test.log
exec "$@"
