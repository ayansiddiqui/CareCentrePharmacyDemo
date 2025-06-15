# LLM Demo Agent Standalone Repository

This directory contains a minimal demo agent using the Hugging Face
Transformers library. It has been moved here so it can be used as a
separate Git repository for portfolio purposes.

## Setup

Create a new repository from this folder:

```bash
cd LLMDemoStandalone
git init
```

Then install requirements and run:

```bash
pip install -r requirements.txt
python llm_agent.py
```

The agent loads `google/flan-t5-small` and lets you chat with it
locally. Type `quit` to exit.
