import sys
from transformers import pipeline


def main():
    model_name = "google/flan-t5-small"  # small model available for free
    generator = pipeline("text2text-generation", model=model_name)
    print("LLM agent ready. Type 'quit' to exit.")
    while True:
        try:
            user_input = input("User: ")
        except EOFError:
            break
        if user_input.lower() in {"quit", "exit"}:
            print("Exiting.")
            break
        response = generator(user_input, max_length=128)
        text = response[0]['generated_text']
        print("Agent:", text)


if __name__ == "__main__":
    main()
